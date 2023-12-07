using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VendorProject
{
    internal class Hasher
    {

        public string HashThis(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                return ByteToHex(md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(input)));
            }
        }

        static string ByteToHex(byte[] bytes)
        {
            StringBuilder stringBuilder = new StringBuilder(bytes.Length);
            for (int i = 0; i < bytes.Length; i++)
            {
                stringBuilder.Append(bytes[i].ToString("X2"));
            }
            return stringBuilder.ToString();
        }

        public bool isEqual(string hash1, string hash2)
        {
            return hash1.Equals(hash2);
        }
    }
}
