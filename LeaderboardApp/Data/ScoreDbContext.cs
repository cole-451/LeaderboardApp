using LeaderboardApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LeaderboardApp.Data
{
    public class ScoreDbContext : DbContext
    {
        public ScoreDbContext(DbContextOptions<ScoreDbContext> options): base(options){  }

        public DbSet<Users> Users { get; set; }
        public DbSet<Songs> Songs { get; set; }
        public DbSet<Scores> Scores { get; set; }
    }
}
