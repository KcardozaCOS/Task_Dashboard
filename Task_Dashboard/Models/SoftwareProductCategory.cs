using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SoftwareProductCategory
    {
        public SoftwareProductCategory()
        {
            SoftProducts = new HashSet<SoftProduct>();
        }

        public Guid Id { get; set; }
        public string Category { get; set; }

        public virtual ICollection<SoftProduct> SoftProducts { get; set; }
    }
}
