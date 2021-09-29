using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgCustDepend
    {
        public Guid Id { get; set; }
        public string ViewName { get; set; }
        public string ParentName { get; set; }
    }
}
