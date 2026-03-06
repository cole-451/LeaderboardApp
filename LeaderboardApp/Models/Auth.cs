namespace LeaderboardApp.Models
{
    public class Auth
    {
        public enum AuthType
        {
            guest,
            user,
            admin,
        }
        public AuthType Role { get; set; }  // renamed from AuthType
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Auth(AuthType role, string email, string username, string password)
        {
            Role = role;
            Email = email;
            Username = username;
            Password = password;
        }
    }
}
