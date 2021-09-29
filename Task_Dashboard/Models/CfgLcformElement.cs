using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcformElement
    {
        public CfgLcformElement()
        {
            CfgLcrecurrentAttachments = new HashSet<CfgLcrecurrentAttachment>();
        }

        public Guid Id { get; set; }
        public Guid FormId { get; set; }
        public string Name { get; set; }
        public Guid? FieldId { get; set; }
        public int? Type { get; set; }
        public int? Rank { get; set; }
        public string Definition { get; set; }

        public virtual CfgLcformDefinition Field { get; set; }
        public virtual CfgLcform Form { get; set; }
        public virtual ICollection<CfgLcrecurrentAttachment> CfgLcrecurrentAttachments { get; set; }
    }
}
