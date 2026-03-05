using LeaderboardApp.Data.Models;
using static LeaderboardApp.Data.Models.Auth;

public static class AuthServiceable
{
    private static List<Auth> Users = new()
    {
        new Auth(AuthType.admin, "admin@gh3.com", "Admin", "admin123"),
        new Auth(AuthType.user, "jake@gh3.com", "SlashFan99", "pass123"),
        new Auth(AuthType.user, "sara@gh3.com", "RockGod42", "pass456"),
    };

    public static Auth? Login(string email, string password)
    {
        return Users.FirstOrDefault(u => u.Email == email && u.Password == password);
    }

    public static void Register(string email, string username, string password)
    {
        Users.Add(new Auth(AuthType.user, email, username, password));
    }
}