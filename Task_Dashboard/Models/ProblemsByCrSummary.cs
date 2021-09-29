using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ProblemsByCrSummary
    {
        public Guid? ChangeRequestId { get; set; }
        public int? Count { get; set; }
    }
}
