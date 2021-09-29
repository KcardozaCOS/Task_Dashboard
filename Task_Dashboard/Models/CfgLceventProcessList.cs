using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLceventProcessList
    {
        public Guid Id { get; set; }
        public Guid ProcessId { get; set; }
        public Guid LceventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
