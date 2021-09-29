using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcprocessItem
    {
        public Guid Id { get; set; }
        public Guid ProcessId { get; set; }
        public Guid LceventId { get; set; }

        public virtual CfgLcevent Lcevent { get; set; }
        public virtual CfgLcprocess Process { get; set; }
    }
}
