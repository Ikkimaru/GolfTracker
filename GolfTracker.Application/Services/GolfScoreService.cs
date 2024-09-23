using GolfTracker.Application.DTOs;
using GolfTracker.Core.Entities;
using GolfTracker.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfTracker.Application.Services
{
    public class GolfScoreService
    {
        private readonly IGolfScoreRepository _golfScoreRepository;

        public GolfScoreService(IGolfScoreRepository golfScoreRepository)
        {
            _golfScoreRepository = golfScoreRepository;
        }

        public async Task<IEnumerable<GolfScoreDto>> GetAllScoresAsync()
        {
            var scores = await _golfScoreRepository.GetAllScoresAsync();
            return scores.Select(s => new GolfScoreDto
            {
                HoleNumber = s.HoleNumber,
                Score = s.Score,
                GolfCourseName = s.GolfCourse.Name,
                DatePlayed = s.DatePlayed
            });
        }

        
        public async Task AddScoreAsync(GolfScoreDto golfScoreDto)
        {
            var score = new GolfScore
            {
                HoleNumber = golfScoreDto.HoleNumber,
                Score = golfScoreDto.Score,
                DatePlayed = golfScoreDto.DatePlayed
            };
            await _golfScoreRepository.AddScoreAsync(score);
        }
    }
}
