using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Report
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ParentForm { get; set; }
        public string Description { get; set; }
        public byte[] Report1 { get; set; }
        public int Format { get; set; }
        public bool Enabled { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public bool Custom { get; set; }
        public Guid? OriginalId { get; set; }
    }
}
