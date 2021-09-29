using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLctaskList
    {
        public Guid Id { get; set; }
        public Guid WfobjectId { get; set; }
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Caption { get; set; }
        public int Rank { get; set; }
        public string GroupName { get; set; }
        public string FormName { get; set; }
        public bool System { get; set; }
        public bool Enabled { get; set; }
        public Guid? FunctionId { get; set; }
        public Guid? ImageId { get; set; }
        public int? ProcessCount { get; set; }
    }
}
