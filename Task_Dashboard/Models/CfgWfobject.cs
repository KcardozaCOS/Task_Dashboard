using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgWfobject
    {
        public CfgWfobject()
        {
            CfgLcevents = new HashSet<CfgLcevent>();
            CfgLcforms = new HashSet<CfgLcform>();
            CfgLcfunctions = new HashSet<CfgLcfunction>();
            CfgLctemplates = new HashSet<CfgLctemplate>();
            CfgWflogs = new HashSet<CfgWflog>();
            CfgWfmacros = new HashSet<CfgWfmacro>();
        }

        public Guid Id { get; set; }
        public Guid ClassId { get; set; }
        public string ObjectName { get; set; }
        public string ViewName { get; set; }

        public virtual ObjectClass Class { get; set; }
        public virtual ICollection<CfgLcevent> CfgLcevents { get; set; }
        public virtual ICollection<CfgLcform> CfgLcforms { get; set; }
        public virtual ICollection<CfgLcfunction> CfgLcfunctions { get; set; }
        public virtual ICollection<CfgLctemplate> CfgLctemplates { get; set; }
        public virtual ICollection<CfgWflog> CfgWflogs { get; set; }
        public virtual ICollection<CfgWfmacro> CfgWfmacros { get; set; }
    }
}
