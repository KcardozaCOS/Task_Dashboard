using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgInvLoadConflictField
    {
        public Guid Id { get; set; }
        public Guid ConflictMemberId { get; set; }
        public string FieldName { get; set; }
        public string AdtFieldValue { get; set; }
        public string DbFieldValue { get; set; }

        public virtual CfgInvLoadConflictMember ConflictMember { get; set; }
    }
}
