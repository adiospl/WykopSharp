using System;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using WykopSharp.Exceptions;
using static WykopSharp.WykopConstants;

namespace WykopSharp
{
    public class ApiParameter : StringMethodParameter
    {
        public ApiParameter(string name, string value) : base(name, value)
        {
        }

        public ApiParameter(string name, long value) : base(name, value)
        {
        }

        public ApiParameter(string name, int value) : base(name, value)
        {
        }

        public ApiParameter(string name, double value) : base(name, value)
        {
        }

        public ApiParameter(string name, bool value) : base(name, value)
        {
        }

        public bool CheckIsApiParameterAllowed()
        {
            return AllowedApiParameters.ContainsValue(Name.ToLower());
        }

        public string AsUriChunk()
        {
            var sb = new StringBuilder();
            if (string.IsNullOrEmpty(Value)) return string.Empty;

            sb.Append(Name);
            sb.Append(",");
            sb.Append(Value);
            sb.Append(",");
            return sb.ToString();
        }
    }

    public class StringMethodParameter : IMethodParameter, IComparable<StringMethodParameter>
    {
        public StringMethodParameter(string name, long value)
            : this(name, value.ToString())
        {
        }

        public StringMethodParameter(string name, int value)
            : this(name, value.ToString())
        {
        }

        public StringMethodParameter(string name, double value)
            : this(name, value.ToString(CultureInfo.InvariantCulture))
        {
        }

        public StringMethodParameter(string name, bool value)
            : this(name, value.ToString())
        {
        }

        public StringMethodParameter(string name, string value)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            if (name.Trim().Length == 0)
                throw new ArgumentException("Parameter cannot be empty or with whitespaces");

            Name = name;
            Value = value;
        }

        public string Value { get; }
        public string Name { get; }

        public bool Equals(IMethodParameter other)
        {
            var eq = other as StringMethodParameter;
            if (eq == null)
                return false;

            return Name == other.Name && Value == eq.Value;
        }

        public int CompareTo(StringMethodParameter obj)
        {
            return string.Compare(Name, obj.Name, StringComparison.Ordinal);
        }
    }

    public class BytePostParameter : PostParameter
    {
        public readonly string FileName;
        public readonly string MimeType;

        public BytePostParameter(string name, byte[] value, string fileName = null, string mimeType = null)
            : base(name, value)
        {
            FileName = fileName ?? "attachment";
            MimeType = mimeType ?? BinaryType.GetFileMimeType(FileName);
        }

        public BytePostParameter(string name, ByteFile file) : base(name)
        {
            Value = file.Data;
            FileName = file.FileName;
            MimeType = file.MimeType;
        }

        public override HttpContent AsHttpContent
        {
            get
            {
                var content = new ByteArrayContent(Value as byte[]);

                content.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = Name,
                    FileName = FileName
                };
                if (!string.IsNullOrWhiteSpace(MimeType))
                    content.Headers.ContentType = new MediaTypeHeaderValue(MimeType);

                return content;
            }
        }

        public override bool Equals(IPostParameter obj)
        {
            var parameter = obj as BytePostParameter;
            if (parameter == null) return false;

            var v = (byte[]) Value;

            return Name == obj.Name && v.SequenceEqual((byte[]) parameter.Value);
        }
    }

    public class StringPostParameter : PostParameter
    {
        public StringPostParameter(string name, object value) : base(name, value)
        {
        }

        public override HttpContent AsHttpContent
        {
            get
            {
                var content = new StringContent(Value.ToString(), Encoding.UTF8);

                content.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = Name
                };
                content.Headers.ContentLength = null;
                content.Headers.ContentType = new MediaTypeHeaderValue("text/plain");
                content.Headers.ContentEncoding.Add("UTF-8");

                return content;
            }
        }
    }

    public abstract class PostParameter : IPostParameter, IComparable<PostParameter>
    {
        protected PostParameter(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            if (name.Trim().Length == 0)
                throw new ArgumentException("Parameter cannot be empty or with whitespaces");

            Name = name;
        }

        protected PostParameter(string name, object value) : this(name)
        {
            if (value is int)
            {
                Value = value.ToString();
            }
            else if (value is string)
            {
                Value = value;
            }
            else if (value is byte[])
            {
                Value = value;
            }
            else
            {
                throw new UnsupportedParameterException("value type {value.GetType()} is not supported");
            }
        }

        public object Value { get; set; }

        public int CompareTo(PostParameter obj)
        {
            return string.Compare(Name, obj.Name, StringComparison.Ordinal);
        }

        public string Name { get; }

        public virtual HttpContent AsHttpContent
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual bool Equals(IPostParameter other)
        {
            var eq = other as PostParameter;
            if (eq == null)
                return false;

            return Name == other.Name && Value == eq.Value;
        }
        
    }
}