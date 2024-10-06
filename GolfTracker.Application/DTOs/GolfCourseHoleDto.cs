using System;

namespace GolfTracker.Application.DTOs
{
    public class GolfCourseHoleDto
    {
        public int HoleNumber { get; set; }
        public int Par { get; set; }
        public int Distance { get; set; }
        public int HandicapStroke { get; set; }
        public string? Description { get; set; }
    }
}
