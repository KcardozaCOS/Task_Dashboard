using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Attachment
    {
        public Attachment()
        {
            CfgEmailAttachments = new HashSet<CfgEmailAttachment>();
            CfgLcrecurrentAttachments = new HashSet<CfgLcrecurrentAttachment>();
            ObjectAttachments = new HashSet<ObjectAttachment>();
        }

        public Guid Id { get; set; }
        public string FileName { get; set; }
        public int? FileSize { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public byte[] Data { get; set; }
        public bool IsFile { get; set; }
        public string FileType { get; set; }
        public Guid? CreatedById { get; set; }
        public string CreatedBy { get; set; }
        public Guid? ModifiedById { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<CfgEmailAttachment> CfgEmailAttachments { get; set; }
        public virtual ICollection<CfgLcrecurrentAttachment> CfgLcrecurrentAttachments { get; set; }
        public virtual ICollection<ObjectAttachment> ObjectAttachments { get; set; }
    }
}
