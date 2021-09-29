using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class KbCategory
    {
        public KbCategory()
        {
            CfgKbCategoryParentChildren = new HashSet<CfgKbCategoryParent>();
            CfgKbCategoryParentParents = new HashSet<CfgKbCategoryParent>();
            InverseParent = new HashSet<KbCategory>();
            KbArticleCategories = new HashSet<KbArticleCategory>();
        }

        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public string Name { get; set; }
        public bool Public { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }

        public virtual KbCategory Parent { get; set; }
        public virtual ICollection<CfgKbCategoryParent> CfgKbCategoryParentChildren { get; set; }
        public virtual ICollection<CfgKbCategoryParent> CfgKbCategoryParentParents { get; set; }
        public virtual ICollection<KbCategory> InverseParent { get; set; }
        public virtual ICollection<KbArticleCategory> KbArticleCategories { get; set; }
    }
}
