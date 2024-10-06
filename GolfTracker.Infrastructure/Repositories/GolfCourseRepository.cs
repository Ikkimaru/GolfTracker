using GolfTracker.Core.Entities;
using GolfTracker.Core.Interfaces;
using GolfTracker.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GolfTracker.Infrastructure.Repositories
{
    public class GolfCourseRepository : IGolfCourseRepository
    {
        private readonly GolfTrackerDbContext _dbContext;

        public GolfCourseRepository(GolfTrackerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<GolfCourse>> GetAllCoursesAsync()
        {
            // Include GolfCourseHoles when fetching GolfCourses
            return await _dbContext.GolfCourses
                .Include(gc => gc.Holes) // Assuming GolfCourse has a navigation property for Holes
                .ToListAsync();
        }
    }
}
