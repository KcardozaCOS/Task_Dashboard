using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLocationParent
    {
        public Guid Id { get; set; }
        public Guid ParentId { get; set; }
        public Guid ChildId { get; set; }

        public virtual Location Child { get; set; }
        public virtual Location Parent { get; set; }
    }
}
