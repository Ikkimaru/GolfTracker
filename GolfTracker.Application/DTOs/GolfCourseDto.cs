using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfTracker.Application.DTOs
{
    public class GolfCourseDto
    {
        public int id { get; set; }
        public required string Name { get; set; }
        public int Holes { get; set; }
    }
}
