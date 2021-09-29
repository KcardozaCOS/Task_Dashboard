using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgWfobjectsView
    {
        public Guid Id { get; set; }
        public Guid ClassId { get; set; }
        public string ObjectName { get; set; }
        public string ObjectTable { get; set; }
        public string CoreTable { get; set; }
        public int ClassIndex { get; set; }
    }
}
