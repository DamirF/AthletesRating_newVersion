using System;

namespace AthletesRating.Models
{
    internal class Security
    {
        public static int GenerateHash(string s)
        {
            int p = 31;
            int hash = 0;
            foreach (var c in s)
                hash = hash * p + c;
            return hash;
        }
        
        public static string AddSult() => GenerateHash(DateTime.Now.ToString()).ToString();
    }
}
