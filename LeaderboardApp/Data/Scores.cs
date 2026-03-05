namespace LeaderboardApp.Data
{
    public class Scores
    {
        public int ScoreID { get; set; }
        public int Score { get; set; }

        // foreign key values
        public int SongID { get; set; }
        public int UserId { get; set; }

        // navigation properties
        public Users Users { get; set; } = null!;
        public Songs Songs { get; set; } = null!;



    }
}
