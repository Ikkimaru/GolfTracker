using GolfTracker.Application.DTOs;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfTracker.Pages // Ensure this matches your namespace structure
{
    public partial class GolfScores
    {
        private List<GolfScoreDto> golfScores;

        protected override async Task OnInitializedAsync()
        {
            golfScores = await GolfScoreService.GetGolfScoresAsync();
        }
    }
}
