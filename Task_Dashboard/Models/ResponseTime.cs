using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ResponseTime
    {
        public Guid Id { get; set; }
        public Guid? PriorityId { get; set; }
        public int? ResponseTime1 { get; set; }
        public int? TargetResolutionTime { get; set; }
        public Guid ServiceLevelId { get; set; }

        public virtual TicketPriority Priority { get; set; }
        public virtual ServiceLevel ServiceLevel { get; set; }
    }
}
