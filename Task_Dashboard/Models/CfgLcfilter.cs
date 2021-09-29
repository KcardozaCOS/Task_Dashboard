using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcfilter
    {
        public CfgLcfilter()
        {
            CfgLcfilterParams = new HashSet<CfgLcfilterParam>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Expression { get; set; }
        public Guid LookupId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CfgLcfilterParam> CfgLcfilterParams { get; set; }
    }
}
