using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgProjectParent
    {
        public Guid Id { get; set; }
        public Guid ParentId { get; set; }
        public Guid ChildId { get; set; }

        public virtual Project Child { get; set; }
        public virtual Project Parent { get; set; }
    }
}
