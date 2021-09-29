using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class AttachmentObjectsList
    {
        public Guid Id { get; set; }
        public Guid AttachmentId { get; set; }
        public string Oid { get; set; }
        public string ObjectName { get; set; }
        public string Class { get; set; }
        public int? ActivityNum { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid ClassId { get; set; }
        public int ClassIndex { get; set; }
        public bool IsFile { get; set; }
        public string FileType { get; set; }
    }
}
