using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgCustFieldsView
    {
        public Guid Id { get; set; }
        public Guid FieldId { get; set; }
        public Guid TableId { get; set; }
        public string TableName { get; set; }
        public string TableXType { get; set; }
        public string FieldName { get; set; }
        public string DefaultLabel { get; set; }
        public string FieldLabel { get; set; }
        public string CustomLabel { get; set; }
        public bool UserField { get; set; }
        public string FieldType { get; set; }
        public int? RefType { get; set; }
        public bool Mandatory { get; set; }
        public bool? ReadOnly { get; set; }
        public int? FieldOrder { get; set; }
        public int LocationIndex { get; set; }
        public bool Hidden { get; set; }
        public int? DecimalDigits { get; set; }
        public string GroupName { get; set; }
        public Guid? RefTableId { get; set; }
        public string RefTableName { get; set; }
        public string RefDisplayFields { get; set; }
        public string RefCondition { get; set; }
        public int? Size { get; set; }
        public string Filter { get; set; }
    }
}
