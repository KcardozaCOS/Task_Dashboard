using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgJobListView
    {
        public Guid Id { get; set; }
        public int JobType { get; set; }
        public string Name { get; set; }
        public string Schedule { get; set; }
        public bool Enabled { get; set; }
        public DateTime? NextRunDate { get; set; }
        public DateTime? LastRunDate { get; set; }
        public int? LastRunStatus { get; set; }
        public string ScheduleText { get; set; }
        public string Description { get; set; }
        public int LogLevel { get; set; }
        public bool Expired { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool RunAsap { get; set; }
        public int? Cid { get; set; }
        public string Name2 { get; set; }
    }
}
