using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgSystemLogView
    {
        public Guid Id { get; set; }
        public DateTime FirstOccurrence { get; set; }
        public DateTime LastOccurrence { get; set; }
        public DateTime? LastNotification { get; set; }
        public DateTime LogDate { get; set; }
        public int SinceNotification { get; set; }
        public int Occurrences { get; set; }
        public int Lid { get; set; }
        public Guid CategoryId { get; set; }
        public string Category { get; set; }
        public Guid? AccountId { get; set; }
        public string Account { get; set; }
        public int Source { get; set; }
        public string SourceName { get; set; }
        public string Details { get; set; }
    }
}
