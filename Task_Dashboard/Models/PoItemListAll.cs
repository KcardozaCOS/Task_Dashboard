using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class PoItemListAll
    {
        public Guid Id { get; set; }
        public Guid PoId { get; set; }
        public int Line { get; set; }
        public string Description { get; set; }
        public string PartNumber { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? Qty { get; set; }
        public decimal? LinePrice { get; set; }
        public DateTime? DateReceived { get; set; }
        public int? QtyReceived { get; set; }
        public string Comment { get; set; }
        public Guid? StatusId { get; set; }
        public Guid? TypeId { get; set; }
        public string Notes { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? ProductId { get; set; }
        public Guid? StockRoomId { get; set; }
        public string Sku { get; set; }
        public int? ReturnPeriod { get; set; }
        public string ReturnPolicy { get; set; }
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
        public Guid? PurchasingUomId { get; set; }
        public int? ConversionFactor { get; set; }
        public Guid? StockingUomId { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string Product { get; set; }
        public string StockRoom { get; set; }
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
        public string PurchasingUom { get; set; }
        public string StockingUom { get; set; }
        public int? FlagStatus { get; set; }
        public DateTime? PoDate { get; set; }
        public string PoNumber { get; set; }
        public string PoTitle { get; set; }
        public string PoRequester { get; set; }
        public string PoVendor { get; set; }
        public string PoStatus { get; set; }
        public Guid? PoStatusId { get; set; }
    }
}
