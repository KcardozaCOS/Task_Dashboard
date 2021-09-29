using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SoftProduct
    {
        public SoftProduct()
        {
            DetectedSoftwareProducts = new HashSet<DetectedSoftwareProduct>();
            InversePartOfSuite = new HashSet<SoftProduct>();
        }

        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public Guid? ManufacturerId { get; set; }
        public string Version { get; set; }
        public string WebPage { get; set; }
        public Guid? PlatformId { get; set; }
        public string Notes { get; set; }
        public string Description { get; set; }
        public string PartNumber { get; set; }
        public bool New { get; set; }
        public Guid? PartOfSuiteId { get; set; }
        public Guid? GroupId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? CategoryId { get; set; }

        public virtual SoftwareProductCategory Category { get; set; }
        public virtual SoftwareProductGroup Group { get; set; }
        public virtual Brand Manufacturer { get; set; }
        public virtual SoftProduct PartOfSuite { get; set; }
        public virtual SoftPlatform Platform { get; set; }
        public virtual CfgTrackedSoftwareProduct CfgTrackedSoftwareProduct { get; set; }
        public virtual ICollection<DetectedSoftwareProduct> DetectedSoftwareProducts { get; set; }
        public virtual ICollection<SoftProduct> InversePartOfSuite { get; set; }
    }
}
