using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcparamsMap
    {
        public Guid Id { get; set; }
        public Guid ParamId { get; set; }
        public Guid CallerId { get; set; }
        public string Value { get; set; }
        public bool Calculated { get; set; }

        public virtual CfgLcfunctionParam Param { get; set; }
    }
}
