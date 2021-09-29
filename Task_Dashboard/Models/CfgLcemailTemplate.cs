using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcemailTemplate
    {
        public CfgLcemailTemplate()
        {
            CfgLcemails = new HashSet<CfgLcemail>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Template { get; set; }

        public virtual ICollection<CfgLcemail> CfgLcemails { get; set; }
    }
}
