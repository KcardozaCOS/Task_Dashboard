using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcobjectHistory
    {
        public Guid Id { get; set; }
        public Guid ObjectId { get; set; }
        public Guid LceventId { get; set; }
        public DateTime RunDate { get; set; }
        public int RunCount { get; set; }

        public virtual CfgLcevent Lcevent { get; set; }
    }
}
