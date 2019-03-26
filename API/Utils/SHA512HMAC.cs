using System;
using System.Text;
using System.Security.Cryptography;

namespace API.Utils
{
    /// <summary>
    /// Support class for sha512 HMAC
    /// </summary>
    class SHA512HMAC
    {
        /// <summary>
        /// Hash with string
        /// </summary>
        public static string Generate(string text, string key)
        {
            using (HMACSHA512 hmac = new HMACSHA512(Encoding.UTF8.GetBytes(key)))
            {
                byte[] hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(text));
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        /// <summary>
        /// Hash with byte array
        /// </summary>
        public static string Generate(byte[] data, string key)
        {
            using (HMACSHA512 hmac = new HMACSHA512(Encoding.UTF8.GetBytes(key)))
            {
                byte[] hash = hmac.ComputeHash(data, 0, data.Length);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }
    }
}