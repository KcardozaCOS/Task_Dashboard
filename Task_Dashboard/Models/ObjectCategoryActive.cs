using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ObjectCategoryActive
    {
        public Guid Id { get; set; }
        public Guid ClassId { get; set; }
        public Guid? ParentId { get; set; }
        public string Category { get; set; }
        public int? Rank { get; set; }
        public bool System { get; set; }
        public string FullName { get; set; }
        public bool Public { get; set; }
        public bool Active { get; set; }
        public string Tags { get; set; }
        public Guid? SubClassId { get; set; }
        public bool ReadOnly { get; set; }
    }
}
