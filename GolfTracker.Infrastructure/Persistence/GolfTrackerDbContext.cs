using Microsoft.EntityFrameworkCore;
using GolfTracker.Core.Entities;
using System.Collections.Generic;

namespace GolfTracker.Infrastructure.Persistence
{
    public class GolfTrackerDbContext : DbContext
    {
        public GolfTrackerDbContext(DbContextOptions<GolfTrackerDbContext> options) : base(options) { }

        public DbSet<GolfCourse> GolfCourses { get; set; }
        public DbSet<GolfScore> GolfScores { get; set; }
    }
}
