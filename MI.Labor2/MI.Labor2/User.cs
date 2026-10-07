using System;

namespace MI.Labor2
{
    public class User
    {
        public string Username { get; set; }
        public string Hash { get; set; }
        public string Timestamp { get; set; }

        public User(string username, string hash, string timestamp)
        {
            Username = username;
            Hash = hash;
            Timestamp = timestamp;
        }
    }
}
