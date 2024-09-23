using GolfTracker.Core.Entities;

namespace GolfTracker.Core.Interfaces
{
    public interface IGolfCourseRepository
    {
        Task<IEnumerable<GolfCourse>> GetAllCoursesAsync();
    }
}
