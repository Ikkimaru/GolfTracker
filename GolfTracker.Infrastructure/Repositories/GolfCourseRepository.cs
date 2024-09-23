using GolfTracker.Core.Entities;
using GolfTracker.Core.Interfaces;
using GolfTracker.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfTracker.Infrastructure.Repositories
{
    public class GolfCourseRepository: IGolfCourseRepository
    {
        private readonly GolfTrackerDbContext _dbContext;

        public GolfCourseRepository(GolfTrackerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<GolfCourse>> GetAllCoursesAsync()
        {
            return await _dbContext.GolfCourses.ToListAsync();
        }
    }
}
