using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgInvLoadConflictPolicy
    {
        public CfgInvLoadConflictPolicy()
        {
            InverseParent = new HashSet<CfgInvLoadConflictPolicy>();
        }

        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public string Type { get; set; }
        public string Caption { get; set; }
        public int? Rank { get; set; }
        public string FieldName { get; set; }
        public int? Operation { get; set; }
        public string Description { get; set; }

        public virtual CfgInvLoadConflictPolicy Parent { get; set; }
        public virtual ICollection<CfgInvLoadConflictPolicy> InverseParent { get; set; }
    }
}
