using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLctemplate
    {
        public CfgLctemplate()
        {
            CfgLcevents = new HashSet<CfgLcevent>();
            CfgLcoperations = new HashSet<CfgLcoperation>();
            CfgLctemplateDefinitions = new HashSet<CfgLctemplateDefinition>();
        }

        public Guid Id { get; set; }
        public Guid WfobjectId { get; set; }
        public string Name { get; set; }
        public bool Custom { get; set; }
        public string Description { get; set; }

        public virtual CfgWfobject Wfobject { get; set; }
        public virtual ICollection<CfgLcevent> CfgLcevents { get; set; }
        public virtual ICollection<CfgLcoperation> CfgLcoperations { get; set; }
        public virtual ICollection<CfgLctemplateDefinition> CfgLctemplateDefinitions { get; set; }
    }
}
