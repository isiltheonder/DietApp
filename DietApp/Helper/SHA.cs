using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Helper
{
    public class SHA
    {
        public string Sha256_Hash(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(x => x.ToString("X2")));
            }
        }
    }
}
