using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgWflogEmail
    {
        public Guid Id { get; set; }
        public Guid LogId { get; set; }
        public string Name { get; set; }
        public int? MessageId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public int? OrderIndex { get; set; }

        public virtual CfgWflog Log { get; set; }
    }
}
