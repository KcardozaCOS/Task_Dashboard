using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgJob
    {
        public CfgJob()
        {
            CfgJobHistories = new HashSet<CfgJobHistory>();
            CfgServiceOperations = new HashSet<CfgServiceOperation>();
            CfgToolLogs = new HashSet<CfgToolLog>();
        }

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

        public virtual ICollection<CfgJobHistory> CfgJobHistories { get; set; }
        public virtual ICollection<CfgServiceOperation> CfgServiceOperations { get; set; }
        public virtual ICollection<CfgToolLog> CfgToolLogs { get; set; }
    }
}
