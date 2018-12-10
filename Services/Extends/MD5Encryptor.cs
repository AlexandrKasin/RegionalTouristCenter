using System.Security.Cryptography;
using System.Text;
using Services.Exceptions;

namespace Services.Extends
{
    public class Md5Encryptor : IEncryptor
    {
        private static string CreateMd5Hash(HashAlgorithm md5Hash, string input)
        {
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sBuilder = new StringBuilder();
            foreach (var t in data)
            {
                sBuilder.Append(t.ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public string GetHash(string input)
        {
            using (var md5Hash = MD5.Create())
            {
                return CreateMd5Hash(md5Hash, input);
            }
        }
    }
}