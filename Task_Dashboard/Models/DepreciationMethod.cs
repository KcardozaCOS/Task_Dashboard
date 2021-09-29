using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class DepreciationMethod
    {
        public DepreciationMethod()
        {
            Assets = new HashSet<Asset>();
        }

        public Guid Id { get; set; }
        public string DepreciationMethod1 { get; set; }
        public double? DepreciationRate { get; set; }
        public string Tags { get; set; }
        public int? Rank { get; set; }
        public bool System { get; set; }

        public virtual ICollection<Asset> Assets { get; set; }
    }
}
