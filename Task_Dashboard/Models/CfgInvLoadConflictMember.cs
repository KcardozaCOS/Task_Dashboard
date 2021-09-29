using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgInvLoadConflictMember
    {
        public CfgInvLoadConflictMember()
        {
            CfgInvLoadConflictFields = new HashSet<CfgInvLoadConflictField>();
        }

        public Guid Id { get; set; }
        public Guid ConflictId { get; set; }
        public Guid ComputerId { get; set; }
        public DateTime? DetectedDate { get; set; }
        public string DbComputerName { get; set; }
        public bool Resolved { get; set; }
        public DateTime? SchedulingDate { get; set; }
        public bool NewComputer { get; set; }

        public virtual CfgInvLoadConflict Conflict { get; set; }
        public virtual ICollection<CfgInvLoadConflictField> CfgInvLoadConflictFields { get; set; }
    }
}
