using System;
using System.IO;

namespace WykopSharp
{
    public class ByteFile
    {
        public static int MaxFileSize = 2097152;
        public ByteFile(byte[] data, string fileName, string mimeType = null)
        {
            if (data.Length == 0)
                throw new ArgumentException("Argument is empty collection", nameof(data));

            Data = data;
            FileName = fileName ?? "file";
            MimeType = mimeType ?? BinaryType.GetFileMimeType(FileName);
        }

        public ByteFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                Data = File.ReadAllBytes(filePath);
                if (Data.Length > MaxFileSize)
                    throw new Exception("file is above {MaxFileSize} bytes. ");

                FileName = Path.GetFileName(filePath);
                MimeType = BinaryType.GetFileMimeType(filePath);
            }
            else
            {
                throw new FileNotFoundException("File is not exists", nameof(filePath));
            }
        }

        public byte[] Data { get; }
        public string FileName { get; }
        public string MimeType { get; }
    }
}