using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcrecurrentAttachment
    {
        public Guid Id { get; set; }
        public Guid ObjectId { get; set; }
        public string FileName { get; set; }
        public int? FileSize { get; set; }
        public string Description { get; set; }
        public byte[] Data { get; set; }
        public Guid? AttachmentId { get; set; }
        public bool IsFile { get; set; }
        public Guid? FormElementId { get; set; }

        public virtual Attachment Attachment { get; set; }
        public virtual CfgLcformElement FormElement { get; set; }
        public virtual CfgLcrecurrentObject Object { get; set; }
    }
}
