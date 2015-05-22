using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ketoansoft.app.Class.Global
{
    class Security
    {
        public static string Encrypt(string cleanString, string salt)
        {
            System.Text.Encoding encoding;
            byte[] clearBytes = null;
            byte[] hashedBytes = null;
            encoding = System.Text.Encoding.GetEncoding("unicode");
            clearBytes = encoding.GetBytes(salt.ToLower().Trim() + cleanString.Trim());
            hashedBytes = MD5hash(clearBytes);
            return BitConverter.ToString(hashedBytes);
        }

        public static string CreateSalt()
        {
            byte[] bytSalt = new byte[9];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytSalt);
            return Convert.ToBase64String(bytSalt);
        }

        public static byte[] MD5hash(byte[] data)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(data);
            return result;
        }
    }
}
