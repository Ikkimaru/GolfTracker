using GolfTracker.Application.DTOs;
using GolfTracker.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfTracker.Application.Services
{
    public  class GolfCourseService
    {
        private readonly IGolfCourseRepository _golfCourseRepository;

        public GolfCourseService(IGolfCourseRepository golfCourseRepository)
        {
            _golfCourseRepository = golfCourseRepository;
        }
        public async Task<IEnumerable<GolfCourseDto>> GetAllGolfCoursesAsync()
        {
            var scores = await _golfCourseRepository.GetAllCoursesAsync();
            return scores.Select(s => new GolfCourseDto
            {
                id = s.Id,
                Name = s.Name,
                Holes = s.Holes
            });
        }
    }
}
