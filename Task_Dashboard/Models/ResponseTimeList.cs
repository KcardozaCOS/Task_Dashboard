using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ResponseTimeList
    {
        public Guid Id { get; set; }
        public Guid? PriorityId { get; set; }
        public int? ResponseTime { get; set; }
        public int? TargetResolutionTime { get; set; }
        public Guid ServiceLevelId { get; set; }
        public string Priority { get; set; }
        public int? PriorityRank { get; set; }
    }
}
