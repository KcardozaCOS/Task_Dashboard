using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgJobHistory
    {
        public Guid Id { get; set; }
        public Guid JobId { get; set; }
        public DateTime LastRunDate { get; set; }
        public int LastRunStatus { get; set; }
        public int RunDuration { get; set; }
        public string RunRemark { get; set; }
        public int ObjectCount { get; set; }

        public virtual CfgJob Job { get; set; }
    }
}
