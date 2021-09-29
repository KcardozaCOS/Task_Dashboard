using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcfunction
    {
        public CfgLcfunction()
        {
            CfgLcevents = new HashSet<CfgLcevent>();
            CfgLcfunctionParams = new HashSet<CfgLcfunctionParam>();
            CfgLcoperationFunctions = new HashSet<CfgLcoperation>();
            CfgLcoperationSubFunctions = new HashSet<CfgLcoperation>();
        }

        public Guid Id { get; set; }
        public Guid WfobjectId { get; set; }
        public int FunctionId { get; set; }
        public string Name { get; set; }
        public string Groups { get; set; }
        public bool Custom { get; set; }
        public string ContextVariable { get; set; }

        public virtual CfgWfobject Wfobject { get; set; }
        public virtual ICollection<CfgLcevent> CfgLcevents { get; set; }
        public virtual ICollection<CfgLcfunctionParam> CfgLcfunctionParams { get; set; }
        public virtual ICollection<CfgLcoperation> CfgLcoperationFunctions { get; set; }
        public virtual ICollection<CfgLcoperation> CfgLcoperationSubFunctions { get; set; }
    }
}
