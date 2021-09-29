using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ScCategory
    {
        public ScCategory()
        {
            InverseParent = new HashSet<ScCategory>();
            ScItemCategories = new HashSet<ScItemCategory>();
        }

        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public string Name { get; set; }
        public bool Public { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }

        public virtual ScCategory Parent { get; set; }
        public virtual ICollection<ScCategory> InverseParent { get; set; }
        public virtual ICollection<ScItemCategory> ScItemCategories { get; set; }
    }
}
