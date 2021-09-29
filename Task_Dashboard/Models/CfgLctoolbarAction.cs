using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLctoolbarAction
    {
        public Guid Id { get; set; }
        public Guid ToolbarId { get; set; }
        public Guid? GroupId { get; set; }
        public Guid? EventId { get; set; }
        public int? Rank { get; set; }

        public virtual CfgLcevent Event { get; set; }
    }
}
