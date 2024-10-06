using GolfTracker.Core.Entities;
using GolfTracker.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfTracker.Data
{
    public static class SeedDataGolfScore
    {
        public static async Task Initialize(GolfTrackerDbContext context)
        {
            // Check if there are already golf scores
            if (context.GolfScores.Any())
            {
                return; // Database has been seeded
            }

            // Add mock golf scores
            var golfScores = new[]
            {
                new GolfScore
                {
                    GolfCourseId = 1, // Assume this is the ID of the Sunnyvale Golf Club
                    PlayerName = "John Doe",
                    DatePlayed = DateTime.Now.AddDays(-1), // Example date played
                    HoleScores = new List<HoleScores>
                    {
                        new HoleScores { HoleNumber = 1, Score = 4 },
                        new HoleScores { HoleNumber = 2, Score = 3 },
                        new HoleScores { HoleNumber = 3, Score = 5 },
                        new HoleScores { HoleNumber = 4, Score = 4 },
                        new HoleScores { HoleNumber = 5, Score = 2 },
                        new HoleScores { HoleNumber = 6, Score = 3 },
                        new HoleScores { HoleNumber = 7, Score = 5 },
                        new HoleScores { HoleNumber = 8, Score = 4 },
                        new HoleScores { HoleNumber = 9, Score = 3 },
                        new HoleScores { HoleNumber = 10, Score = 4 },
                        new HoleScores { HoleNumber = 11, Score = 3 },
                        new HoleScores { HoleNumber = 12, Score = 5 },
                        new HoleScores { HoleNumber = 13, Score = 4 },
                        new HoleScores { HoleNumber = 14, Score = 3 },
                        new HoleScores { HoleNumber = 15, Score = 5 },
                        new HoleScores { HoleNumber = 16, Score = 4 },
                        new HoleScores { HoleNumber = 17, Score = 3 },
                        new HoleScores { HoleNumber = 18, Score = 4 },
                    }
                },
                new GolfScore
                {
                    GolfCourseId = 2, // Assume this is the ID of the Riverside Golf Course
                    PlayerName = "Jane Smith",
                    DatePlayed = DateTime.Now.AddDays(-2), // Example date played
                    HoleScores = new List<HoleScores>
                    {
                        new HoleScores { HoleNumber = 1, Score = 4 },
                        new HoleScores { HoleNumber = 2, Score = 2 },
                        new HoleScores { HoleNumber = 3, Score = 3 },
                        new HoleScores { HoleNumber = 4, Score = 5 },
                        new HoleScores { HoleNumber = 5, Score = 4 },
                        new HoleScores { HoleNumber = 6, Score = 3 },
                        new HoleScores { HoleNumber = 7, Score = 4 },
                        new HoleScores { HoleNumber = 8, Score = 3 },
                        new HoleScores { HoleNumber = 9, Score = 5 },
                    }
                }
            };

            context.GolfScores.AddRange(golfScores);
            await context.SaveChangesAsync();
        }
    }
}
