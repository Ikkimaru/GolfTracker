using GolfTracker.Core.Entities;
using GolfTracker.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GolfTracker.Data
{
    public static class SeedData
    {
        public static async Task Initialize(GolfTrackerDbContext context)
        {
            // Ensure the database is created
            await context.Database.EnsureCreatedAsync();

            // Check if there are already golf courses
            if (context.GolfCourses.Any())
            {
                return; // Database has been seeded
            }

            // Add mock golf courses
            var courses = new[]
            {
                new GolfCourse { Name = "Sunnyvale Golf Club", Holes = 18 },
                new GolfCourse { Name = "Riverside Golf Course", Holes = 9 },
                new GolfCourse { Name = "Mountain View Golf Course", Holes = 18 }
            };

            await context.GolfCourses.AddRangeAsync(courses);
            await context.SaveChangesAsync();

            // Add mock golf scores
            var scores = new[]
            {
                new GolfScore { GolfCourseId = 1, HoleNumber = 1, Score = 4, DatePlayed = DateTime.Now.AddDays(-10) },
                new GolfScore { GolfCourseId = 1, HoleNumber = 2, Score = 3, DatePlayed = DateTime.Now.AddDays(-10) },
                new GolfScore { GolfCourseId = 2, HoleNumber = 1, Score = 5, DatePlayed = DateTime.Now.AddDays(-5) },
                new GolfScore { GolfCourseId = 3, HoleNumber = 1, Score = 4, DatePlayed = DateTime.Now.AddDays(-1) }
            };

            await context.GolfScores.AddRangeAsync(scores);
            await context.SaveChangesAsync();
        }
    }
}
