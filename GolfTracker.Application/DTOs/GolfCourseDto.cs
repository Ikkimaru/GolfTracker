using System.Collections.Generic;

namespace GolfTracker.Application.DTOs
{
    public class GolfCourseDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<GolfCourseHoleDto> Holes { get; set; } = new();
    }
}
