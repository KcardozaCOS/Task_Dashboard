using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcfunctionParam
    {
        public CfgLcfunctionParam()
        {
            CfgLcparamsMaps = new HashSet<CfgLcparamsMap>();
        }

        public Guid Id { get; set; }
        public Guid FunctionId { get; set; }
        public string ParamName { get; set; }
        public int ParamType { get; set; }
        public int ParamNum { get; set; }
        public string DefaultValue { get; set; }
        public bool Calculated { get; set; }
        public string TableName { get; set; }
        public Guid? LookupId { get; set; }

        public virtual CfgLcfunction Function { get; set; }
        public virtual ICollection<CfgLcparamsMap> CfgLcparamsMaps { get; set; }
    }
}
