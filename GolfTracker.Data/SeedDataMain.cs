using GolfTracker.Infrastructure.Persistence;
using System.Threading.Tasks;

namespace GolfTracker.Data
{
    public static class SeedDataMain
    {
        public static async Task Initialize(GolfTrackerDbContext context)
        {
            // Ensure the database is created
            await context.Database.EnsureCreatedAsync();

            // Seed Golf Course data
            await SeedDataGolfCourse.Initialize(context);

            // Seed Golf Score data
            await SeedDataGolfScore.Initialize(context);
        }
    }
}
