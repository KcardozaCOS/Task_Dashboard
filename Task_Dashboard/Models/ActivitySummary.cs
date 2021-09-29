using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ActivitySummary
    {
        public Guid ObjectId { get; set; }
        public int? Count { get; set; }
        public DateTime? LastActivity { get; set; }
    }
}
