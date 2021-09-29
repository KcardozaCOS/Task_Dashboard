using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ObjectList
    {
        public Guid Id { get; set; }
        public int ClassIndex { get; set; }
        public string Class { get; set; }
        public string ObjectName { get; set; }
        public string Oid { get; set; }
        public Guid ClassId { get; set; }
        public Guid? StatusId { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
