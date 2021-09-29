using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcfunctionCallerList
    {
        public Guid? Id { get; set; }
        public int? Cid { get; set; }
        public string Kind { get; set; }
        public string Name { get; set; }
        public Guid? WfobjectId { get; set; }
    }
}
