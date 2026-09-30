using System;
using System.Collections.Generic;
using System.Text;

namespace MIPHazi
{
    public class Security
    {
        public static string HashPassword(string password)
        {
            int shift = 3;
            StringBuilder hashed = new StringBuilder();

            try
            {
                for (int i = 0; i < password.Length; i++)
                {
                    char character = password[i];
                    hashed.Append((char)(character + shift));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Hiba tortent: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Titkositas befejezve.");
            }

            return hashed.ToString();
        }
        public static bool VerifyPassword(string rawPassword, string hashedPassword)
        {
            string hashedRawPassword = HashPassword(rawPassword);
            return hashedRawPassword == hashedPassword;
        }
    }
}
