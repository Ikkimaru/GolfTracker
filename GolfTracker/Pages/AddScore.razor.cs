using GolfTracker.Core.Entities;
using GolfTracker.Application.DTOs;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GolfTracker.Services;

public class AddScoreBase : ComponentBase
{
    protected GolfScoreDto score = new GolfScoreDto
    {
        HoleScores = new List<HoleScoreDto>()
    };

    protected List<GolfCourseDto> golfCourses = new List<GolfCourseDto>(); // Initialize the list
    protected string selectedGameType = "18"; // Default game type
    protected string errorMessage;

    [Inject]
    protected GolfCourseService GolfCourseService { get; set; }

    [Inject]
    protected GolfScoreService GolfScoreService { get; set; }

    [Inject]
    protected NavigationManager NavigationManager { get; set; }

    protected override async Task OnInitializedAsync()
    {
        // Load the list of golf courses
        golfCourses = await GolfCourseService.GetGolfCoursesAsync();

        // Ensure that HoleScores is initialized based on the default selected game type
        UpdateHoleScores();
    }

    protected void OnGameTypeChanged(ChangeEventArgs e)
    {
        selectedGameType = e.Value.ToString();
        UpdateHoleScores();

        // Validate if the selected golf course has enough holes
        if (golfCourses != null && golfCourses.Count > 0)
        {
            var selectedCourse = golfCourses.FirstOrDefault(c => c.Id == score.GolfCourseId);
            if (selectedCourse != null && selectedCourse.Holes.Count < (selectedGameType == "18" ? 18 : 9))
            {
                errorMessage = $"The selected course '{selectedCourse.Name}' does not have enough holes for a {selectedGameType}-hole game.";
            }
            else
            {
                errorMessage = null; // Reset error message
            }
        }

        int holesCount = selectedGameType == "18" ? 18 : 9;
        score.HoleScores = Enumerable.Range(1, holesCount)
            .Select(h => new HoleScoreDto { HoleNumber = h })
            .ToList();
    }

    private void UpdateHoleScores()
    {
        int numberOfHoles = selectedGameType == "18" ? 18 : 9;
        score.HoleScores = Enumerable.Range(1, numberOfHoles)
            .Select(h => new HoleScoreDto { HoleNumber = h })
            .ToList();
    }

    protected async Task HandleValidSubmit()
    {
        await GolfScoreService.AddGolfScoreAsync(score);
        NavigationManager.NavigateTo("/scores");
    }
}
