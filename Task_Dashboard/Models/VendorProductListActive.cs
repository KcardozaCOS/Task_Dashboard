using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class VendorProductListActive
    {
        public Guid Id { get; set; }
        public Guid VendorId { get; set; }
        public Guid ProductId { get; set; }
        public decimal? Price { get; set; }
        public Guid? StatusId { get; set; }
        public Guid? TypeId { get; set; }
        public string Sku { get; set; }
        public int? ReturnPeriod { get; set; }
        public string ReturnPolicy { get; set; }
        public string WebPage { get; set; }
        public string Notes { get; set; }
        public string Vendor { get; set; }
        public string VendorOid { get; set; }
        public string VendorStatus { get; set; }
        public string VendorType { get; set; }
        public string VendorCategory { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public Guid? VendorStatusId { get; set; }
        public bool? Preferred { get; set; }
        public string Product { get; set; }
        public string ProductOid { get; set; }
        public string ProductStatus { get; set; }
        public string ProductType { get; set; }
        public string ProductCategory { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
        public string PartNumber { get; set; }
        public decimal? Msrp { get; set; }
        public int? WarrantyPeriod { get; set; }
        public string WarrantyDetails { get; set; }
        public string Status { get; set; }
        public string ProductAndPrice { get; set; }
        public Guid? ProductStatusId { get; set; }
        public string VendorAndPrice { get; set; }
    }
}
