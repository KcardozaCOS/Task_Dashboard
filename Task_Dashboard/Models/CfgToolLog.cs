using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgToolLog
    {
        public CfgToolLog()
        {
            CfgArchiveDatabases = new HashSet<CfgArchiveDatabase>();
        }

        public Guid Id { get; set; }
        public Guid? ToolId { get; set; }
        public DateTime RunDate { get; set; }
        public bool Critical { get; set; }
        public Guid? JobId { get; set; }
        public string LogDirectory { get; set; }
        public string RunParams { get; set; }
        public int? RunDuration { get; set; }
        public string RunRemark { get; set; }
        public string Stat1 { get; set; }
        public string Stat2 { get; set; }
        public string Stat3 { get; set; }
        public string Stat4 { get; set; }
        public string Stat5 { get; set; }
        public byte[] Data { get; set; }
        public string Stat6 { get; set; }
        public string Stat7 { get; set; }
        public string LogName { get; set; }
        public DateTime UploadDate { get; set; }

        public virtual CfgJob Job { get; set; }
        public virtual ICollection<CfgArchiveDatabase> CfgArchiveDatabases { get; set; }
    }
}
