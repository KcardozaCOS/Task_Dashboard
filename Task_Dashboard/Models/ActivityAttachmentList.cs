using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ActivityAttachmentList
    {
        public Guid Id { get; set; }
        public Guid ActivityId { get; set; }
        public Guid AttachmentId { get; set; }
        public string FileName { get; set; }
        public int? FileSize { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public byte[] Data { get; set; }
        public bool IsFile { get; set; }
        public string Type { get; set; }
        public string FileType { get; set; }
        public int? LinkCount { get; set; }
    }
}
