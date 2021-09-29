using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcprocess
    {
        public CfgLcprocess()
        {
            CfgLcprocessItems = new HashSet<CfgLcprocessItem>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CfgLcprocessItem> CfgLcprocessItems { get; set; }
    }
}
