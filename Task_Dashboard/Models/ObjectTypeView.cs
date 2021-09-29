using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ObjectTypeView
    {
        public Guid Id { get; set; }
        public Guid ClassId { get; set; }
        public string Type { get; set; }
        public int? Rank { get; set; }
        public bool System { get; set; }
        public bool Active { get; set; }
        public string Tags { get; set; }
        public string TypeFullName { get; set; }
    }
}
