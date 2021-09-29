using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcfunctionList
    {
        public Guid Id { get; set; }
        public Guid WfobjectId { get; set; }
        public string Name { get; set; }
        public int FunctionId { get; set; }
        public int? UsageCount { get; set; }
        public int? ParameterCount { get; set; }
    }
}
