using GolfTracker.Application.DTOs;
using GolfTracker.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace GolfTracker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GolfCourseController : ControllerBase
    {
        private readonly GolfCourseService _golfCourseService;

        public GolfCourseController(GolfCourseService golfCourseService)
        {
            _golfCourseService = golfCourseService;
        }
        [HttpGet("courses")]
        public async Task<IEnumerable<GolfCourseDto>> GetAllGolfCourses()
        {
            return await _golfCourseService.GetAllGolfCoursesAsync(); // Assuming this method is implemented in your service
        }
    }
}
