using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SharedViewListSummary
    {
        public Guid Id { get; set; }
        public string ObjectName { get; set; }
        public string Name { get; set; }
        public int RoleCount { get; set; }
    }
}
