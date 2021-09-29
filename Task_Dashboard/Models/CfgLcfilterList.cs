using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcfilterList
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Expression { get; set; }
        public Guid LookupId { get; set; }
        public string Description { get; set; }
        public int? Lookup { get; set; }
    }
}
