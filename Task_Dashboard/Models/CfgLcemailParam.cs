using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcemailParam
    {
        public CfgLcemailParam()
        {
            CfgLcemailParamsMaps = new HashSet<CfgLcemailParamsMap>();
        }

        public Guid Id { get; set; }
        public Guid EmailId { get; set; }
        public string ParamName { get; set; }
        public int ParamType { get; set; }
        public int ParamNum { get; set; }
        public string DefaultValue { get; set; }
        public bool Calculated { get; set; }
        public string TableName { get; set; }
        public Guid? LookupId { get; set; }

        public virtual CfgLcemail Email { get; set; }
        public virtual ICollection<CfgLcemailParamsMap> CfgLcemailParamsMaps { get; set; }
    }
}
