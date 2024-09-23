using GolfTracker.Core.Entities;

namespace GolfTracker.Core.Interfaces
{
    public interface IGolfScoreRepository
    {
        Task<IEnumerable<GolfScore>> GetAllScoresAsync();
        Task AddScoreAsync(GolfScore golfScore);
    }
}
