using System;

namespace MI.Labor2
{
    class Program
    {
        static void Main()
        {
            var auth = new AuthService();

            // Register a user
            var user = auth.Register("alice", "password123");
            Console.WriteLine($"Registered user: {user.Username} (timestamp {user.Timestamp})");

            // Try login with wrong password
            try
            {
                Console.WriteLine("Attempting login with wrong password...");
                auth.Authenticate("alice", "wrongpass");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Invalid credentials");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("First login attempt finished (finally block).");
            }

            // Correct login
            try
            {
                var logged = auth.Authenticate("alice", "password123");
                Console.WriteLine($"Login successful for {logged.Username}");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Invalid credentials");
            }

            // Update password (GDPR update)
            auth.UpdatePassword("alice", "newpass456");
            Console.WriteLine("Password updated.");

            // Login with new password
            try
            {
                auth.Authenticate("alice", "newpass456");
                Console.WriteLine("Login with new password successful.");
            }
            catch
            {
                Console.WriteLine("Invalid credentials");
            }

            // GDPR delete
            auth.DeleteUser("alice");
            Console.WriteLine("User deleted (GDPR).");
        }
    }
}
