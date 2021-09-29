using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgKbCategoryParent
    {
        public Guid Id { get; set; }
        public Guid ParentId { get; set; }
        public Guid ChildId { get; set; }

        public virtual KbCategory Child { get; set; }
        public virtual KbCategory Parent { get; set; }
    }
}
