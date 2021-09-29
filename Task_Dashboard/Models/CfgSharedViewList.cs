using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgSharedViewList
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ObjectBrowser { get; set; }
        public string ObjectTable { get; set; }
        public string ObjectName { get; set; }
    }
}
