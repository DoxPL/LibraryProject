using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class PasswordUtil
    {
        public static string PasswordHash(string input)
        {
            var bytes = new UTF8Encoding().GetBytes(input);
            byte[] hash;
            using (var hashAlgorithm = new System.Security.Cryptography.SHA256Managed())
            {
                hash = hashAlgorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hash);
        }

        public static string GeneratePassword(int length)
        {
            Random random = new Random();
            string rndPassword = "";
            for(int i=0; i<length; i++)
            {
                rndPassword += (char)(random.Next(48, 122));
            }
            return rndPassword;
        }
    }
}
