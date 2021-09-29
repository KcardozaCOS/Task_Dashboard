using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ObjectAttachmentsSummary
    {
        public Guid ObjectId { get; set; }
        public int? Count { get; set; }
        public int? TotalSize { get; set; }
    }
}
