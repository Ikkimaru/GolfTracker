namespace GolfTracker.Core.Entities
{
    public class GolfScore : BaseEntity
    {
        public GolfScore() 
        {
            HoleScores = new List<HoleScores>();
        }
        public int GolfCourseId { get; set; }
        public string PlayerName { get; set; }
        public List<HoleScores> HoleScores { get; set; }
        public DateTime DatePlayed { get; set; }

        public GolfCourse GolfCourse { get; set; }
    }
}
