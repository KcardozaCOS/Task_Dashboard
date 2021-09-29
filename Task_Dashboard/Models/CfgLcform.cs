using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcform
    {
        public CfgLcform()
        {
            CfgLcevents = new HashSet<CfgLcevent>();
            CfgLcformDefinitions = new HashSet<CfgLcformDefinition>();
            CfgLcformElements = new HashSet<CfgLcformElement>();
            CfgLcformFields = new HashSet<CfgLcformField>();
            CfgLcformValidations = new HashSet<CfgLcformValidation>();
        }

        public Guid Id { get; set; }
        public Guid WfobjectId { get; set; }
        public string Name { get; set; }
        public string FormCaption { get; set; }
        public string Instruction { get; set; }
        public string Description { get; set; }
        public bool Custom { get; set; }
        public bool IsWizard { get; set; }
        public bool IsViewForm { get; set; }

        public virtual CfgWfobject Wfobject { get; set; }
        public virtual ICollection<CfgLcevent> CfgLcevents { get; set; }
        public virtual ICollection<CfgLcformDefinition> CfgLcformDefinitions { get; set; }
        public virtual ICollection<CfgLcformElement> CfgLcformElements { get; set; }
        public virtual ICollection<CfgLcformField> CfgLcformFields { get; set; }
        public virtual ICollection<CfgLcformValidation> CfgLcformValidations { get; set; }
    }
}
