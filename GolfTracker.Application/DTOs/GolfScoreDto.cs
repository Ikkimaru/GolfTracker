namespace GolfTracker.Application.DTOs
{
    public class GolfScoreDto
    {
        public int Id { get; set; }
        public int GolfCourseId { get; set; }
        public string PlayerName { get; set; }
        public string GolfCourseName { get; set; } // Name of the golf course
        public List<HoleScoreDto> HoleScores { get; set; } // List of hole scores
        public DateTime DatePlayed { get; set; } // Date when the game was played
    }
}
