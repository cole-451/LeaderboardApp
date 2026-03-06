using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaderboardApp.Models
{
    public class Users
    {
        public int Id { get; set; }
        [Required]
        public required string Username { get; set; }
        [NotMapped]
        public string? Email { get; set; }
    }
}
