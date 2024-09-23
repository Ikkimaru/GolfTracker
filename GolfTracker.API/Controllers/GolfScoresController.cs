using GolfTracker.Application.DTOs;
using GolfTracker.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GolfTracker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GolfScoresController : ControllerBase
    {
        private readonly GolfScoreService _golfScoreService;

        public GolfScoresController(GolfScoreService golfScoreService)
        {
            _golfScoreService = golfScoreService;
        }

        [HttpGet("score")]
        public async Task<IEnumerable<GolfScoreDto>> GetAllScores()
        {
            return await _golfScoreService.GetAllScoresAsync();
        }

        [HttpPost("score")]
        public async Task<IActionResult> AddScore([FromBody] GolfScoreDto golfScoreDto)
        {
            await _golfScoreService.AddScoreAsync(golfScoreDto);
            return Ok();
        }

        
    }
}

