using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ScItemCategory
    {
        public Guid Id { get; set; }
        public Guid ScCategoryId { get; set; }
        public Guid ScItemId { get; set; }

        public virtual ScCategory ScCategory { get; set; }
        public virtual ServiceCatalogItem ScItem { get; set; }
    }
}
