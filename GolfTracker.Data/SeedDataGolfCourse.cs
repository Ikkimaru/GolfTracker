using GolfTracker.Core.Entities;
using GolfTracker.Infrastructure.Persistence;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfTracker.Data
{
    public static class SeedDataGolfCourse
    {
        public static async Task Initialize(GolfTrackerDbContext context)
        {
            // Check if there are already golf courses
            if (context.GolfCourses.Any())
            {
                return; // Database has been seeded
            }

            // Add mock golf courses with holes
            var courses = new[]
            {
                new GolfCourse
                {
                    Id = 1,
                    Name = "Sunnyvale Golf Club",
                    NumberOfHoles = 18,
                    Holes = new List<GolfCourseHole>
                    {
                        new GolfCourseHole { HoleNumber = 1, Par = 4, Distance = 350, HandicapStroke = 1, Description = "A challenging opening hole with a slight dogleg.", GolfCourseId = 1 },
                        new GolfCourseHole { HoleNumber = 2, Par = 3, Distance = 180, HandicapStroke = 2, Description = "A picturesque par 3 with a water hazard.", GolfCourseId = 1 },
                        new GolfCourseHole { HoleNumber = 3, Par = 5, Distance = 500, HandicapStroke = 3, Description = "A long hole that requires strategic placement.", GolfCourseId = 1 },
                        new GolfCourseHole { HoleNumber = 4, Par = 4, Distance = 400, HandicapStroke = 4, Description = "A straight hole with a bunker on the right.", GolfCourseId = 1 },
                        new GolfCourseHole { HoleNumber = 5, Par = 3, Distance = 200, HandicapStroke = 5, Description = "A downhill par 3 that tests your accuracy.", GolfCourseId = 1 },
                        new GolfCourseHole { HoleNumber = 6, Par = 4, Distance = 350, HandicapStroke = 6, Description = "A short par 4 that invites aggressive play.", GolfCourseId = 1 },
                        new GolfCourseHole { HoleNumber = 7, Par = 5, Distance = 550, HandicapStroke = 7, Description = "A long par 5 that can be reached in two with a good drive.", GolfCourseId = 1 },
                        new GolfCourseHole { HoleNumber = 8, Par = 4, Distance = 420, HandicapStroke = 8, Description = "A tight hole with trees lining both sides.", GolfCourseId = 1 },
                        new GolfCourseHole { HoleNumber = 9, Par = 3, Distance = 190, HandicapStroke = 9, Description = "A scenic par 3 over a small creek.", GolfCourseId = 1 },
                        new GolfCourseHole { HoleNumber = 10, Par = 4, Distance = 350, HandicapStroke = 10, Description = "A welcoming start to the back nine.", GolfCourseId = 1 },
                        new GolfCourseHole { HoleNumber = 11, Par = 4, Distance = 380, HandicapStroke = 11, Description = "A longer hole with a narrow fairway.", GolfCourseId = 1 },
                        new GolfCourseHole { HoleNumber = 12, Par = 5, Distance = 520, HandicapStroke = 12, Description = "A reachable par 5 with careful shot placement.", GolfCourseId = 1 },
                        new GolfCourseHole { HoleNumber = 13, Par = 4, Distance = 400, HandicapStroke = 13, Description = "A straight hole with a large green.", GolfCourseId = 1 },
                        new GolfCourseHole { HoleNumber = 14, Par = 3, Distance = 180, HandicapStroke = 14, Description = "A challenging par 3 that plays into the wind.", GolfCourseId = 1 },
                        new GolfCourseHole { HoleNumber = 15, Par = 5, Distance = 540, HandicapStroke = 15, Description = "A long par 5 with a water hazard on the left.", GolfCourseId = 1 },
                        new GolfCourseHole { HoleNumber = 16, Par = 4, Distance = 360, HandicapStroke = 16, Description = "A straight par 4 with a wide fairway.", GolfCourseId = 1 },
                        new GolfCourseHole { HoleNumber = 17, Par = 3, Distance = 200, HandicapStroke = 17, Description = "An uphill par 3 with a tricky green.", GolfCourseId = 1 },
                        new GolfCourseHole { HoleNumber = 18, Par = 4, Distance = 420, HandicapStroke = 18, Description = "A strong finishing hole with a view of the clubhouse.", GolfCourseId = 1 }
                    }
                },
                new GolfCourse
                {
                    Id = 2,
                    Name = "Riverside Golf Course",
                    NumberOfHoles = 9,
                    Holes = new List<GolfCourseHole>
                    {
                        new GolfCourseHole { HoleNumber = 1, Par = 4, Distance = 360, HandicapStroke = 1, Description = "A straight hole that opens the course.", GolfCourseId = 2 },
                        new GolfCourseHole { HoleNumber = 2, Par = 3, Distance = 170, HandicapStroke = 2, Description = "A short par 3 with a deep green.", GolfCourseId = 2 },
                        new GolfCourseHole { HoleNumber = 3, Par = 4, Distance = 390, HandicapStroke = 3, Description = "A challenging hole with a dogleg right.", GolfCourseId = 2 },
                        new GolfCourseHole { HoleNumber = 4, Par = 5, Distance = 510, HandicapStroke = 4, Description = "A long par 5 with a water hazard in play.", GolfCourseId = 2 },
                        new GolfCourseHole { HoleNumber = 5, Par = 3, Distance = 180, HandicapStroke = 5, Description = "A scenic par 3 over a small pond.", GolfCourseId = 2 },
                        new GolfCourseHole { HoleNumber = 6, Par = 4, Distance = 400, HandicapStroke = 6, Description = "A solid par 4 with a challenging green.", GolfCourseId = 2 },
                        new GolfCourseHole { HoleNumber = 7, Par = 4, Distance = 380, HandicapStroke = 7, Description = "A narrow fairway leads to a well-guarded green.", GolfCourseId = 2 },
                        new GolfCourseHole { HoleNumber = 8, Par = 5, Distance = 520, HandicapStroke = 8, Description = "A long par 5 that can be reached with two good shots.", GolfCourseId = 2 },
                        new GolfCourseHole { HoleNumber = 9, Par = 3, Distance = 200, HandicapStroke = 9, Description = "A tricky par 3 that plays longer than it looks.", GolfCourseId = 2 },
                    }
                },
                new GolfCourse
                {
                    Id = 3,
                    Name = "Mountain View Golf Course",
                    NumberOfHoles = 18,
                    Holes = new List<GolfCourseHole>
                    {
                        new GolfCourseHole { HoleNumber = 1, Par = 4, Distance = 380, HandicapStroke = 1, Description = "A long straight hole with a wide fairway.", GolfCourseId = 3 },
                        new GolfCourseHole { HoleNumber = 2, Par = 3, Distance = 175, HandicapStroke = 2, Description = "A short and sweet par 3.", GolfCourseId = 3 },
                        new GolfCourseHole { HoleNumber = 3, Par = 4, Distance = 350, HandicapStroke = 3, Description = "A tight hole that requires accuracy.", GolfCourseId = 3 },
                        new GolfCourseHole { HoleNumber = 4, Par = 5, Distance = 500, HandicapStroke = 4, Description = "A long hole with a wide open fairway.", GolfCourseId = 3 },
                        new GolfCourseHole { HoleNumber = 5, Par = 3, Distance = 180, HandicapStroke = 5, Description = "A downhill par 3 with a challenging pin placement.", GolfCourseId = 3 },
                        new GolfCourseHole { HoleNumber = 6, Par = 4, Distance = 410, HandicapStroke = 6, Description = "A par 4 with a slight dogleg.", GolfCourseId = 3 },
                        new GolfCourseHole { HoleNumber = 7, Par = 5, Distance = 540, HandicapStroke = 7, Description = "A long par 5 with a narrow approach.", GolfCourseId = 3 },
                        new GolfCourseHole { HoleNumber = 8, Par = 4, Distance = 370, HandicapStroke = 8, Description = "A strong par 4 with a well-guarded green.", GolfCourseId = 3 },
                        new GolfCourseHole { HoleNumber = 9, Par = 3, Distance = 190, HandicapStroke = 9, Description = "A short hole with a beautiful view.", GolfCourseId = 3 },
                        new GolfCourseHole { HoleNumber = 10, Par = 4, Distance = 360, HandicapStroke = 10, Description = "An inviting hole to start the back nine.", GolfCourseId = 3 },
                        new GolfCourseHole { HoleNumber = 11, Par = 4, Distance = 380, HandicapStroke = 11, Description = "A demanding hole with a tricky green.", GolfCourseId = 3 },
                        new GolfCourseHole { HoleNumber = 12, Par = 5, Distance = 510, HandicapStroke = 12, Description = "A reachable par 5 with careful shot placement.", GolfCourseId = 3 },
                        new GolfCourseHole { HoleNumber = 13, Par = 4, Distance = 400, HandicapStroke = 13, Description = "A straight hole with a large green.", GolfCourseId = 3 },
                        new GolfCourseHole { HoleNumber = 14, Par = 3, Distance = 190, HandicapStroke = 14, Description = "A challenging par 3 that plays into the wind.", GolfCourseId = 3 },
                        new GolfCourseHole { HoleNumber = 15, Par = 5, Distance = 540, HandicapStroke = 15, Description = "A long par 5 with a water hazard on the left.", GolfCourseId = 3 },
                        new GolfCourseHole { HoleNumber = 16, Par = 4, Distance = 360, HandicapStroke = 16, Description = "A straight par 4 with a wide fairway.", GolfCourseId = 3 },
                        new GolfCourseHole { HoleNumber = 17, Par = 3, Distance = 200, HandicapStroke = 17, Description = "An uphill par 3 with a tricky green.", GolfCourseId = 3 },
                        new GolfCourseHole { HoleNumber = 18, Par = 4, Distance = 420, HandicapStroke = 18, Description = "A strong finishing hole with a view of the clubhouse.", GolfCourseId = 3 }
                    }
                }
            };

            context.GolfCourses.AddRange(courses);
            await context.SaveChangesAsync();
        }
    }
}
