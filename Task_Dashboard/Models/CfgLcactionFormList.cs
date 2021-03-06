using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcactionFormList
    {
        public Guid Id { get; set; }
        public Guid WfobjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FormCaption { get; set; }
        public string Instruction { get; set; }
        public int? UsageCount { get; set; }
        public int? FieldCount { get; set; }
        public string WindowStyle { get; set; }
    }
}
