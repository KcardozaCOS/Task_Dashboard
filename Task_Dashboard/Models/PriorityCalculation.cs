using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class PriorityCalculation
    {
        public Guid Id { get; set; }
        public Guid? UrgencyId { get; set; }
        public Guid? ImpactId { get; set; }
        public Guid? PriorityId { get; set; }
        public Guid? ServiceLevelId { get; set; }

        public virtual TicketImpact Impact { get; set; }
        public virtual TicketPriority Priority { get; set; }
        public virtual ServiceLevel ServiceLevel { get; set; }
        public virtual TicketUrgency Urgency { get; set; }
    }
}
