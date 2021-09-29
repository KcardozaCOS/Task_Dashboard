using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLceventList
    {
        public Guid Id { get; set; }
        public Guid WfobjectId { get; set; }
        public int Cid { get; set; }
        public string Kind { get; set; }
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Caption { get; set; }
        public Guid? FormId { get; set; }
        public string FormName { get; set; }
        public Guid? FunctionId { get; set; }
        public Guid? TemplateId { get; set; }
        public bool Enabled { get; set; }
        public bool AnyRole { get; set; }
        public bool Embedded { get; set; }
        public int? ProcessCount { get; set; }
    }
}
