namespace GolfTracker.Core.Entities
{
    public class GolfCourse : BaseEntity
    {
        public string Name { get; set; } // Name of the golf course
        public int NumberOfHoles { get; set; } // Indicate 9/18 holes
        public List<GolfCourseHole> Holes { get; set; } // List of holes for the course

        public GolfCourse()
        {
            Holes = new List<GolfCourseHole>();
        }
    }
}
