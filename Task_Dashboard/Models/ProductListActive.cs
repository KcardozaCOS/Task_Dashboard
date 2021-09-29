using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ProductListActive
    {
        public Guid Id { get; set; }
        public string Oid { get; set; }
        public Guid? StatusId { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? CategoryId { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public Guid? ManufacturerId { get; set; }
        public string Description { get; set; }
        public string PartNumber { get; set; }
        public decimal? Msrp { get; set; }
        public int? WarrantyPeriod { get; set; }
        public string WarrantyDetails { get; set; }
        public Guid? PurchasingUomId { get; set; }
        public Guid? StockingUomId { get; set; }
        public Guid? ProductClassId { get; set; }
        public Guid? AssetTypeId { get; set; }
        public Guid? AssetCategoryId { get; set; }
        public Guid? ConsumableTypeId { get; set; }
        public Guid? ConsumableCategoryId { get; set; }
        public Guid? ComputerTypeId { get; set; }
        public Guid? ComputerCategoryId { get; set; }
        public Guid? HardwareTypeId { get; set; }
        public Guid? HardwareCategoryId { get; set; }
        public Guid? SoftwareLicenseTypeId { get; set; }
        public Guid? SoftwareLicenseCategoryId { get; set; }
        public int? ConversionFactor { get; set; }
        public string Notes { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }
        public string Manufacturer { get; set; }
        public bool Attachments { get; set; }
        public int AttachmentsCount { get; set; }
        public int AttachmentsTotalSize { get; set; }
        public int ActivityCount { get; set; }
        public int? FlagStatus { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int LinksCount { get; set; }
        public string PurchasingUom { get; set; }
        public string StockingUom { get; set; }
        public string ProductClass { get; set; }
        public string AssetType { get; set; }
        public string AssetCategory { get; set; }
        public string ConsumableType { get; set; }
        public string ConsumableCategory { get; set; }
        public string ComputerType { get; set; }
        public string ComputerCategory { get; set; }
        public string HardwareType { get; set; }
        public string HardwareCategory { get; set; }
        public string SoftwareLicenseType { get; set; }
        public string SoftwareLicenseCategory { get; set; }
    }
}
