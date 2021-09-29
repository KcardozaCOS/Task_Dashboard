using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class PriorityCalculationList
    {
        public Guid Id { get; set; }
        public Guid? UrgencyId { get; set; }
        public Guid? ImpactId { get; set; }
        public Guid? PriorityId { get; set; }
        public Guid? ServiceLevelId { get; set; }
        public string Urgency { get; set; }
        public string Impact { get; set; }
        public string Priority { get; set; }
    }
}
