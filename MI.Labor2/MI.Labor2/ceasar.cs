using System;
using System.Collections.Generic;
using System.Text;

namespace MI.Labor2
{
    public class Caesar
    {
        private int Shift = 3;
        
        public string Encrypt(string password, string timestamp)
        {
            string combined = password + timestamp;
            StringBuilder encrypted = new StringBuilder();

            foreach (char c in combined)
            {
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    int shifted = (c - baseChar + Shift) % 26;
                    encrypted.Append((char)(baseChar + shifted));
                }
                else
                {
                    encrypted.Append(c);
                }
            }

            return encrypted.ToString();
        }

        // Verifies a password against a stored hash and timestamp
        public bool Verify(string password, string timestamp, string hash)
        {
            if (password == null || timestamp == null || hash == null)
                return false;

            string computed = Encrypt(password, timestamp);
            return string.Equals(computed, hash, StringComparison.Ordinal);
        }
    }
}
