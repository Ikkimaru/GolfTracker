namespace GolfTracker.Core.Entities
{
    public class GolfScore
    {
        public int Id { get; set; }
        public int GolfCourseId { get; set; }
        public int HoleNumber { get; set; }
        public int Score { get; set; }
        public DateTime DatePlayed { get; set; }

        public GolfCourse GolfCourse { get; set; }
    }
}
