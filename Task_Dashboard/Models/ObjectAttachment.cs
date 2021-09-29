using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ObjectAttachment
    {
        public Guid Id { get; set; }
        public Guid ObjectId { get; set; }
        public Guid? ActivityId { get; set; }
        public Guid AttachmentId { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual Attachment Attachment { get; set; }
        public virtual ObjectIndex Object { get; set; }
    }
}
