using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class DiscoveredLicSoftByObjectSummary
    {
        public Guid SoftwareLicenseId { get; set; }
        public Guid ObjectId { get; set; }
        public int Discovered { get; set; }
    }
}
