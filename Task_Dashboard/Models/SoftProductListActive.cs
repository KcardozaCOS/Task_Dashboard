using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SoftProductListActive
    {
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
        public string PartOfSuite { get; set; }
        public string Manufacturer { get; set; }
        public string Platform { get; set; }
        public Guid? TrackedSoftwareId { get; set; }
        public string TrackedSoftware { get; set; }
        public int? Discovered { get; set; }
        public int? Used { get; set; }
        public string Group { get; set; }
        public bool? GroupIgnored { get; set; }
        public string Category { get; set; }
        public bool? Suite { get; set; }
    }
}
