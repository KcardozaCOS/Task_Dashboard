using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SoftwareProductGroup
    {
        public SoftwareProductGroup()
        {
            SoftProducts = new HashSet<SoftProduct>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Ignored { get; set; }

        public virtual ICollection<SoftProduct> SoftProducts { get; set; }
    }
}
