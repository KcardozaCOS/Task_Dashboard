using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcrecurrentObject
    {
        public CfgLcrecurrentObject()
        {
            CfgLcrecurrentAttachments = new HashSet<CfgLcrecurrentAttachment>();
            CfgLcrecurrentFields = new HashSet<CfgLcrecurrentField>();
        }

        public Guid Id { get; set; }
        public Guid LceventId { get; set; }
        public Guid CreatedById { get; set; }

        public virtual Person CreatedBy { get; set; }
        public virtual CfgLcevent Lcevent { get; set; }
        public virtual ICollection<CfgLcrecurrentAttachment> CfgLcrecurrentAttachments { get; set; }
        public virtual ICollection<CfgLcrecurrentField> CfgLcrecurrentFields { get; set; }
    }
}
