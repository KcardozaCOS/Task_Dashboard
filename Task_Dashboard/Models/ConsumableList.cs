using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ConsumableList
    {
        public Guid Id { get; set; }
        public string Oid { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? StatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? OwnerId { get; set; }
        public Guid? OrganizationId { get; set; }
        public Guid? LocationId { get; set; }
        public string Notes { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal? OriginalCost { get; set; }
        public string PurchaseOrder { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public int? OriginalQty { get; set; }
        public Guid? PoItemId { get; set; }
        public Guid? ManufacturerId { get; set; }
        public string Model { get; set; }
        public string Version { get; set; }
        public string Sku { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string PartNumber { get; set; }
        public int? Qty { get; set; }
        public Guid? ProductId { get; set; }
        public Guid? StockRoomId { get; set; }
        public Guid? VendorId { get; set; }
        public Guid? StockingUomId { get; set; }
        public string Owner { get; set; }
        public string Organization { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool Attachments { get; set; }
        public int AttachmentsCount { get; set; }
        public int AttachmentsTotalSize { get; set; }
        public int ActivityCount { get; set; }
        public int? FlagStatus { get; set; }
        public string Manufacturer { get; set; }
        public int LinksCount { get; set; }
        public string Vendor { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Cost { get; set; }
        public string Product { get; set; }
        public string StockRoom { get; set; }
        public string StockingUom { get; set; }
    }
}
