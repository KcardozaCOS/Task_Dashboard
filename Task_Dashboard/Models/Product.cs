using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Product
    {
        public Product()
        {
            Assets = new HashSet<Asset>();
            Consumables = new HashSet<Consumable>();
            PoItems = new HashSet<PoItem>();
            StockRules = new HashSet<StockRule>();
            VendorProducts = new HashSet<VendorProduct>();
        }

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

        public virtual ObjectCategory AssetCategory { get; set; }
        public virtual ObjectType AssetType { get; set; }
        public virtual ObjectCategory Category { get; set; }
        public virtual ObjectCategory ComputerCategory { get; set; }
        public virtual ObjectType ComputerType { get; set; }
        public virtual ObjectCategory ConsumableCategory { get; set; }
        public virtual ObjectType ConsumableType { get; set; }
        public virtual ObjectCategory HardwareCategory { get; set; }
        public virtual ObjectType HardwareType { get; set; }
        public virtual Brand Manufacturer { get; set; }
        public virtual ObjectClass ProductClass { get; set; }
        public virtual UnitsOfMeasure PurchasingUom { get; set; }
        public virtual ObjectCategory SoftwareLicenseCategory { get; set; }
        public virtual ObjectType SoftwareLicenseType { get; set; }
        public virtual Status Status { get; set; }
        public virtual UnitsOfMeasure StockingUom { get; set; }
        public virtual ObjectType Type { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
        public virtual ICollection<Consumable> Consumables { get; set; }
        public virtual ICollection<PoItem> PoItems { get; set; }
        public virtual ICollection<StockRule> StockRules { get; set; }
        public virtual ICollection<VendorProduct> VendorProducts { get; set; }
    }
}
