using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLceventViewList
    {
        public Guid Id { get; set; }
        public Guid WfobjectId { get; set; }
        public int EventKind { get; set; }
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Caption { get; set; }
        public string Hint { get; set; }
        public int Rank { get; set; }
        public string Types { get; set; }
        public string Statuses { get; set; }
        public string Condition { get; set; }
        public int? Interval { get; set; }
        public Guid? TemplateId { get; set; }
        public Guid? FormId { get; set; }
        public Guid? FunctionId { get; set; }
        public string Message { get; set; }
        public bool System { get; set; }
        public bool Enabled { get; set; }
        public string Params { get; set; }
        public string GroupName { get; set; }
        public bool AnyRole { get; set; }
        public bool Reopen { get; set; }
        public Guid? ImageId { get; set; }
        public bool Embedded { get; set; }
        public int? ProcessCount { get; set; }
    }
}
