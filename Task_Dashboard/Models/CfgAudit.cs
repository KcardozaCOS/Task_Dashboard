using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgAudit
    {
        public Guid Id { get; set; }
        public Guid ComputerId { get; set; }
        public DateTime? AuditDate { get; set; }
        public byte[] Data { get; set; }
        public byte[] Scan { get; set; }
    }
}
