using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class DetectedProductList
    {
        public Guid Id { get; set; }
        public Guid SoftProductId { get; set; }
        public Guid ObjectId { get; set; }
        public DateTime? InstallDate { get; set; }
        public string InstallKey { get; set; }
        public string SerialNum { get; set; }
        public DateTime? FirstAudit { get; set; }
        public DateTime? LastAudit { get; set; }
        public string ProductName { get; set; }
        public string Version { get; set; }
        public string Platform { get; set; }
        public string Manufacturer { get; set; }
        public string TrackedSoftware { get; set; }
        public string LicenseAllocated { get; set; }
    }
}
