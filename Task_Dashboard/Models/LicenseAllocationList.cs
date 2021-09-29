using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class LicenseAllocationList
    {
        public Guid Id { get; set; }
        public Guid ObjectId { get; set; }
        public Guid SoftwareLicenseId { get; set; }
        public DateTime? AllocationDate { get; set; }
        public string DeviceName { get; set; }
        public string Owner { get; set; }
        public string Organization { get; set; }
        public string Location { get; set; }
        public string Reconciled { get; set; }
    }
}
