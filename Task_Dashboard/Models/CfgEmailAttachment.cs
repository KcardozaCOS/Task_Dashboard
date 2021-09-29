using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgEmailAttachment
    {
        public Guid Id { get; set; }
        public Guid EmailId { get; set; }
        public Guid AttachmentId { get; set; }

        public virtual Attachment Attachment { get; set; }
        public virtual CfgEmailQueue Email { get; set; }
    }
}
