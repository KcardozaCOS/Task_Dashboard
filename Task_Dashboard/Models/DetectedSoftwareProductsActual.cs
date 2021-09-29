using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class DetectedSoftwareProductsActual
    {
        public Guid Id { get; set; }
        public Guid SoftProductId { get; set; }
        public Guid ObjectId { get; set; }
        public DateTime? InstallDate { get; set; }
        public string InstallKey { get; set; }
        public string SerialNum { get; set; }
        public DateTime? FirstAudit { get; set; }
        public DateTime? LastAudit { get; set; }
    }
}
