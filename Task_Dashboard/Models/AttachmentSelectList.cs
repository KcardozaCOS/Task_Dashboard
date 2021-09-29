using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class AttachmentSelectList
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public int? FileSize { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid? CreatedById { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Guid? ModifiedById { get; set; }
        public string Description { get; set; }
        public bool IsFile { get; set; }
        public string FileType { get; set; }
        public string AttachmentType { get; set; }
        public Guid ObjectId { get; set; }
        public string Oid { get; set; }
        public string ObjectName { get; set; }
        public Guid? StatusId { get; set; }
        public Guid? TypeId { get; set; }
        public Guid ClassId { get; set; }
        public string ObjectClass { get; set; }
        public int ClassIndex { get; set; }
        public string ObjectStatus { get; set; }
        public string ObjectType { get; set; }
    }
}
