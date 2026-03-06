using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaderboardApp.Models
{
    public class Scores
    {
        public int ID { get; set; }
        [Required]
        public int Score { get; set; }

        // foreign key values
        [ForeignKey(nameof(Songs.ID))]
        public int SongID { get; set; }
        [ForeignKey(nameof(Users.Id))]
        public int UserId { get; set; }

        // navigation properties
        [Required]
        public Users Users { get; set; } = null!;
        [Required]
        public Songs Songs { get; set; } = null!;



    }
}
