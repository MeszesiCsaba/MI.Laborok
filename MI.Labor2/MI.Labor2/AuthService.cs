using System;
using System.Collections.Generic;

namespace MI.Labor2
{
    public class AuthService
    {
        private readonly List<User> _users = new List<User>();
        private readonly Caesar _caesar = new Caesar();

        // Register a new user using Caesar encryption (password + timestamp)
        public User Register(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username required", nameof(username));
            if (password == null)
                throw new ArgumentException("Password required", nameof(password));

            string timestamp = DateTime.UtcNow.ToString("o");
            string hash = _caesar.Encrypt(password, timestamp);
            var user = new User(username, hash, timestamp);
            _users.Add(user);
            return user;
        }

        // Authenticate returns the user when successful or throws on failure
        public User Authenticate(string username, string password)
        {
            var user = _users.Find(u => u.Username == username);
            if (user == null)
                throw new UnauthorizedAccessException("Invalid credentials");

            bool ok = _caesar.Verify(password, user.Timestamp, user.Hash);
            if (!ok)
                throw new UnauthorizedAccessException("Invalid credentials");

            return user;
        }

        // Update password (GDPR update example)
        public void UpdatePassword(string username, string newPassword)
        {
            var user = _users.Find(u => u.Username == username);
            if (user == null)
                throw new InvalidOperationException("User not found");

            string timestamp = DateTime.UtcNow.ToString("o");
            string hash = _caesar.Encrypt(newPassword, timestamp);
            user.Hash = hash;
            user.Timestamp = timestamp;
        }

        // Delete user (GDPR delete example)
        public void DeleteUser(string username)
        {
            var user = _users.Find(u => u.Username == username);
            if (user == null)
                throw new InvalidOperationException("User not found");

            _users.Remove(user);
        }

        // Helper for demo/tests
        public IEnumerable<User> GetAllUsers() => _users.AsReadOnly();
    }
}
