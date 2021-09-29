using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgObjectDependenciesView
    {
        public string ReferenceName { get; set; }
        public string FieldName { get; set; }
        public string RefFieldName { get; set; }
        public int DbtableId { get; set; }
        public string TableName { get; set; }
        public string RefTableName { get; set; }
    }
}
