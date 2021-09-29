using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgSystemLog
    {
        public Guid Id { get; set; }
        public DateTime LastOccurrence { get; set; }
        public int Lid { get; set; }
        public Guid CategoryId { get; set; }
        public Guid? AccountId { get; set; }
        public int Source { get; set; }
        public string Details { get; set; }
        public Guid? InitiatorId { get; set; }
        public DateTime FirstOccurrence { get; set; }
        public int Occurrences { get; set; }
        public DateTime? LastNotification { get; set; }
        public int SinceNotification { get; set; }

        public virtual CfgSystemLogCategory Category { get; set; }
    }
}
