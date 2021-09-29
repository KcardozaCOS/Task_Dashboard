using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgSolutionRatingsSummary
    {
        public Guid ObjectId { get; set; }
        public int? TotalVotes { get; set; }
        public int? RatingAverage { get; set; }
    }
}
