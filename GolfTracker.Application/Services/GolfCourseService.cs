using GolfTracker.Application.DTOs;
using GolfTracker.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfTracker.Application.Services
{
    public class GolfCourseService
    {
        private readonly IGolfCourseRepository _golfCourseRepository;

        public GolfCourseService(IGolfCourseRepository golfCourseRepository)
        {
            _golfCourseRepository = golfCourseRepository;
        }

        public async Task<IEnumerable<GolfCourseDto>> GetAllGolfCoursesAsync()
        {
            var courses = await _golfCourseRepository.GetAllCoursesAsync();
            return courses.Select(c => new GolfCourseDto
            {
                Id = c.Id,
                Name = c.Name,
                Holes = c.Holes.Select(h => new GolfCourseHoleDto
                {
                    HoleNumber = h.HoleNumber,
                    Par = h.Par,
                    Distance = h.Distance,
                    HandicapStroke = h.HandicapStroke,
                    Description = h.Description
                }).ToList()
            });
        }
    }
}
