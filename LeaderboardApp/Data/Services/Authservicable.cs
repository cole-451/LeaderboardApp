using LeaderboardApp.Models;
using LeaderboardApp.Data;
using Microsoft.EntityFrameworkCore;

public class AuthServiceable
{
    private readonly ScoreDbContext _db;

    public AuthServiceable(ScoreDbContext db)
    {
        _db = db;
    }

    public Users? Login(string email, string password)
    {
        return _db.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
    }

    public void Register(string email, string username, string password)
    {
        var newUser = new Users
        {
            Email = email,
            Username = username,
            Password = password,
            Role = "user"
        };
        _db.Users.Add(newUser);
        _db.SaveChanges();
    }
}