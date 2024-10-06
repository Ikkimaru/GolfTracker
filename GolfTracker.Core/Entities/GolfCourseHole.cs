namespace GolfTracker.Core.Entities
{
    public class GolfCourseHole : BaseEntity
    {
        public int GolfCourseId { get; set; }
        public int HoleNumber { get; set; } // The hole number (1 to 18 or 1 to 9)
        public int Par { get; set; } // The par value for the hole
        public int Distance { get; set; } // The distance to the hole (in yards or meters)
        public string Description { get; set; } // Any additional information about the hole
        /// <summary>
        /// An integer representing the number of strokes that a player can deduct based on their handicap for this specific hole.
        /// </summary>
        public int HandicapStroke { get; set; }

        // Optional: Constructor for easier initialization
        public GolfCourseHole(int holeNumber, int par, int distance, int handicapStroke, string description = "")
        {
            HoleNumber = holeNumber;
            Par = par;
            Distance = distance;
            HandicapStroke = handicapStroke;
            Description = description;
        }

        public GolfCourseHole()
        {
        }
    }
}
