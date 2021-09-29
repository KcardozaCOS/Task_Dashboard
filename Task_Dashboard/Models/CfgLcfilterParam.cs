using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcfilterParam
    {
        public Guid Id { get; set; }
        public Guid FilterId { get; set; }
        public string ParamName { get; set; }
        public int ParamType { get; set; }
        public string TableName { get; set; }
        public Guid? LookupId { get; set; }

        public virtual CfgLcfilter Filter { get; set; }
    }
}
