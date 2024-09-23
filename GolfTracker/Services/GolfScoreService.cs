using GolfTracker.Application.DTOs;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GolfTracker.Services
{
    public class GolfScoreService
    {
        private readonly HttpClient _httpClient;

        public GolfScoreService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<GolfScoreDto>> GetGolfScoresAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<GolfScoreDto>>("api/GolfScores/score");
        }

        public async Task AddGolfScoreAsync(GolfScoreDto golfScoreDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/GolfScores/score", golfScoreDto);
            response.EnsureSuccessStatusCode(); // Throw an exception if the response is not successful
        }

    }
}
