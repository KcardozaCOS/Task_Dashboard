using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class LicenseAllocationsActual
    {
        public Guid Id { get; set; }
        public Guid SoftwareLicenseId { get; set; }
        public Guid ObjectId { get; set; }
        public DateTime? AllocationDate { get; set; }
        public bool AutoDeallocate { get; set; }
        public bool AutoAdded { get; set; }
        public Guid? TrackedSoftwareId { get; set; }
    }
}
