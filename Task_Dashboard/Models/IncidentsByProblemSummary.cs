using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class IncidentsByProblemSummary
    {
        public Guid? RelatedProblemId { get; set; }
        public int? Count { get; set; }
    }
}
