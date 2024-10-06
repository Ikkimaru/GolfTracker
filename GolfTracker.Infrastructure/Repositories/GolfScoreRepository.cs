using GolfTracker.Core.Entities;
using GolfTracker.Core.Interfaces;
using GolfTracker.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GolfTracker.Infrastructure.Repositories
{
    public class GolfScoreRepository : IGolfScoreRepository
    {
        private readonly GolfTrackerDbContext _dbContext;

        public GolfScoreRepository(GolfTrackerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<GolfScore>> GetAllScoresAsync()
        {
            return await _dbContext.GolfScores
                .Include(gs => gs.GolfCourse) // Include GolfCourse data
                .Include(gs => gs.HoleScores)  // Include HoleScores data if necessary
                .ToListAsync();
        }

        public async Task AddScoreAsync(GolfScore golfScore)
        {
            await _dbContext.GolfScores.AddAsync(golfScore);
            await _dbContext.SaveChangesAsync();
        }
    }
}
