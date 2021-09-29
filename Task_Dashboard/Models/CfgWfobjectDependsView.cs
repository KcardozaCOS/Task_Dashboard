using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgWfobjectDependsView
    {
        public string TableName { get; set; }
        public string RefField { get; set; }
        public Guid RefObjectId { get; set; }
        public string RefTable { get; set; }
        public string RefName { get; set; }
        public string RefWhere { get; set; }
        public string RefType { get; set; }
    }
}
