using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcserviceAttribute
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public string Expression { get; set; }
        public bool System { get; set; }
        public int ServiceKind { get; set; }
    }
}
