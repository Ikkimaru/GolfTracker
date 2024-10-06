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
                Id = s.Id,
                GolfCourseId = s.GolfCourseId,
                PlayerName = s.PlayerName,
                GolfCourseName = s.GolfCourse.Name,
                HoleScores = s.HoleScores.Select(h => new HoleScoreDto
                {
                    HoleNumber = h.HoleNumber,
                    Score = h.Score
                }).ToList(),
                DatePlayed = s.DatePlayed
            });
        }

        public async Task AddScoreAsync(GolfScoreDto golfScoreDto)
        {
            var score = new GolfScore
            {
                GolfCourseId = golfScoreDto.GolfCourseId,
                PlayerName = golfScoreDto.PlayerName,
                HoleScores = golfScoreDto.HoleScores.Select(h => new HoleScores
                {
                    HoleNumber = h.HoleNumber,
                    Score = h.Score
                }).ToList(),
                DatePlayed = golfScoreDto.DatePlayed
            };
            await _golfScoreRepository.AddScoreAsync(score);
        }

    }
}
