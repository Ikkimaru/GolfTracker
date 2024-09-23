using GolfTracker.Application.DTOs;

namespace GolfTracker.Services
{
    public class GolfCourseService
    {
        private readonly HttpClient _httpClient;

        public GolfCourseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<GolfCourseDto>> GetGolfCoursesAsync()
        {
            // Assuming there's an API endpoint to get the golf courses
            return await _httpClient.GetFromJsonAsync<List<GolfCourseDto>>("api/GolfCourse/courses");
        }
    }
}
