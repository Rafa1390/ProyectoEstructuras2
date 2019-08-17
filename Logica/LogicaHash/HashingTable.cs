using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Logica.LogicaHash
{
    public class HashingTable
    {
        private Dictionary<string, object> dict = new Dictionary<string, object>();


        public HashingTable()
        {
            dict = new Dictionary<string, object>();
        }

        public int Count()
        {
            return dict.Keys.Count;
        }
        public bool ContainsKey(string key)
        {
            key = GetHashString(key);
            return dict.ContainsKey(key);
        }

        public void Add(string key, Object value)
        {
            key = GetHashString(key);
            if (!dict.ContainsKey(key))
            {
                dict.Add(key, value);
            }
        }
        public void Remove(string key)
        {
            key = GetHashString(key);
            if (!dict.ContainsKey(key))
            {
                dict.Remove(key);
            }
        }

        public object Get(string key)
        {
            key = GetHashString(key);
            if (dict.ContainsKey(key))
            {
                return dict[key];
            }
            return null;
        }
        public static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }


        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
    }
}
