using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class StatusView
    {
        public Guid Id { get; set; }
        public Guid ClassId { get; set; }
        public string Status { get; set; }
        public int? Rank { get; set; }
        public bool System { get; set; }
        public bool Active { get; set; }
        public string Tags { get; set; }
        public Guid? ImageId { get; set; }
        public string StatusFullName { get; set; }
    }
}
