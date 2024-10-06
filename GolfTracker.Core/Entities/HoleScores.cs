using System.ComponentModel.DataAnnotations;

namespace GolfTracker.Core.Entities
{
    public class HoleScores : BaseEntity
    {
        public int GolfScoreId { get; set; }
        public HoleScores() { }


        public int HoleNumber { get; set; }
        public int Score { get; set; }
    }
}
