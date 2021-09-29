using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgCustField
    {
        public CfgCustField()
        {
            CfgCustFieldValues = new HashSet<CfgCustFieldValue>();
            CfgCustTableFields = new HashSet<CfgCustTableField>();
        }

        public Guid Id { get; set; }
        public string FieldName { get; set; }
        public string DefaultLabel { get; set; }
        public bool UserField { get; set; }
        public string FieldType { get; set; }
        public int? FieldOrder { get; set; }
        public string GroupName { get; set; }
        public int? RefType { get; set; }
        public int LocationIndex { get; set; }
        public bool Hidden { get; set; }
        public int? DecimalDigits { get; set; }

        public virtual ICollection<CfgCustFieldValue> CfgCustFieldValues { get; set; }
        public virtual ICollection<CfgCustTableField> CfgCustTableFields { get; set; }
    }
}
