using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcemailList
    {
        public Guid Id { get; set; }
        public Guid WfobjectId { get; set; }
        public string Name { get; set; }
        public int MessageId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Subject { get; set; }
        public string ContentType { get; set; }
        public int? UsageCount { get; set; }
        public int? ParameterCount { get; set; }
        public string Template { get; set; }
    }
}
