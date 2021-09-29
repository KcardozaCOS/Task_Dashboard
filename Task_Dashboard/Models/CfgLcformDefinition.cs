using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcformDefinition
    {
        public CfgLcformDefinition()
        {
            CfgLcformElements = new HashSet<CfgLcformElement>();
            CfgLcrecurrentFields = new HashSet<CfgLcrecurrentField>();
        }

        public Guid Id { get; set; }
        public Guid FormId { get; set; }
        public string FieldName { get; set; }
        public int FieldNum { get; set; }
        public string FieldValue { get; set; }
        public bool Calculated { get; set; }
        public bool? Mandatory { get; set; }
        public bool? ReadOnly { get; set; }
        public bool Virtual { get; set; }
        public string FieldLabel { get; set; }
        public string Filter { get; set; }
        public string Hint { get; set; }

        public virtual CfgLcform Form { get; set; }
        public virtual ICollection<CfgLcformElement> CfgLcformElements { get; set; }
        public virtual ICollection<CfgLcrecurrentField> CfgLcrecurrentFields { get; set; }
    }
}
