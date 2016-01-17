using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;
using Windows.UI.Core;

namespace WykopSharp.Auth
{
    internal class AuthSignature
    {
        private readonly string _appSecret;
        private readonly string _postValuesString;
        private readonly Uri _url;

        public AuthSignature(string appSecret, Uri url)
        {
            if (appSecret == null)
                throw new ArgumentNullException(nameof(appSecret));
            if (url == null)
                throw new ArgumentNullException(nameof(url));

            _appSecret = appSecret;
            _url = url;
        }

        public AuthSignature(string appSecret, Uri url, SortedSet<PostParameter> postParameters)
            : this(appSecret, url)
        {
            var postValues = postParameters
                .Where(p => p is StringPostParameter)
                .Select(p => p.Value.ToString())
                .ToArray();

            _postValuesString = string.Join(",", postValues);
        }

        public string FetchSignature()
        {
            //var md5 = Windows.Security.Cryptography.Core.HashAlgorithmNames.Md5;
            //md5.
            //using (var md5Hash = MD5.Create())
            //{
            var sb = new StringBuilder();
            sb.Append(_appSecret);
            sb.Append(_url);
            if(_postValuesString != null)
                sb.Append(_postValuesString);

            return ComputeMD5(sb.ToString());
            //}
        }

        //private static string GetMd5Hash(MD5 md5Hash, string input)
        //{
        //    var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
        //    return BitConverter.ToString(data).Replace("-", "");
        //}

        private static string ComputeMD5(string str)
        {
            var alg = HashAlgorithmProvider.OpenAlgorithm(HashAlgorithmNames.Md5);
            IBuffer buff = CryptographicBuffer.ConvertStringToBinary(str, BinaryStringEncoding.Utf8);
            var hashed = alg.HashData(buff);
            var res = CryptographicBuffer.EncodeToHexString(hashed);
            return res;
        }
    }
}