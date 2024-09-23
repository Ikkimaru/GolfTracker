namespace GolfTracker.Application.DTOs
{
    public class GolfScoreDto
    {
        public int HoleNumber { get; set; }
        public int Score { get; set; }
        public string GolfCourseName { get; set; }
        public DateTime DatePlayed { get; set; }
    }
}
