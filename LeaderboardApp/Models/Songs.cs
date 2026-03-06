using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaderboardApp.Models
{
    public class Songs
    {
        
        public int ID { get; set; }
        [Required]
        public required string SongName { get; set; }
        [NotMapped]
        public string? SongArtist { get; set; }
        [NotMapped]
        public string? CoveredBy { get; set; }
    }
}
