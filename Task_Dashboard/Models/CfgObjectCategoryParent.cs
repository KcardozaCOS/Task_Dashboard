using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgObjectCategoryParent
    {
        public Guid Id { get; set; }
        public Guid ParentId { get; set; }
        public Guid ChildId { get; set; }

        public virtual ObjectCategory Child { get; set; }
        public virtual ObjectCategory Parent { get; set; }
    }
}
