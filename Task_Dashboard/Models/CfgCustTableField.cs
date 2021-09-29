using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgCustTableField
    {
        public Guid Id { get; set; }
        public Guid FieldId { get; set; }
        public Guid TableId { get; set; }
        public string CustomLabel { get; set; }
        public Guid? RefTableId { get; set; }
        public string RefCondition { get; set; }
        public bool Mandatory { get; set; }
        public bool ReadOnly { get; set; }
        public string Filter { get; set; }

        public virtual CfgCustField Field { get; set; }
        public virtual CfgCustTable RefTable { get; set; }
        public virtual CfgCustTable Table { get; set; }
    }
}
