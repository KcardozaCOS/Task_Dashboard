using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgWorkOrderParent
    {
        public Guid Id { get; set; }
        public Guid ParentId { get; set; }
        public Guid ChildId { get; set; }

        public virtual ObjectIndex Child { get; set; }
        public virtual ObjectIndex Parent { get; set; }
    }
}
