using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ObjectAttachmentList
    {
        public Guid Id { get; set; }
        public Guid AttachmentId { get; set; }
        public string FileName { get; set; }
        public int? FileSize { get; set; }
        public string CreatedBy { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid? ModifiedById { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Description { get; set; }
        public byte[] Data { get; set; }
        public bool IsFile { get; set; }
        public string Type { get; set; }
        public string FileType { get; set; }
        public Guid ObjectId { get; set; }
        public int? ActivityNum { get; set; }
        public int? LinkCount { get; set; }
    }
}
