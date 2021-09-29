using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SoftPlatform
    {
        public SoftPlatform()
        {
            SoftProducts = new HashSet<SoftProduct>();
        }

        public Guid Id { get; set; }
        public string Platform { get; set; }
        public int? Rank { get; set; }
        public bool System { get; set; }
        public string Tags { get; set; }

        public virtual ICollection<SoftProduct> SoftProducts { get; set; }
    }
}
