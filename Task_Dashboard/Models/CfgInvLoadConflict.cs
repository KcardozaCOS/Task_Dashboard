using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgInvLoadConflict
    {
        public CfgInvLoadConflict()
        {
            CfgInvLoadConflictMembers = new HashSet<CfgInvLoadConflictMember>();
        }

        public Guid Id { get; set; }
        public Guid SessionId { get; set; }
        public Guid AuditId { get; set; }
        public string AdtComputerName { get; set; }
        public short ConflictStatus { get; set; }
        public DateTime? ResolutionDate { get; set; }

        public virtual ICollection<CfgInvLoadConflictMember> CfgInvLoadConflictMembers { get; set; }
    }
}
