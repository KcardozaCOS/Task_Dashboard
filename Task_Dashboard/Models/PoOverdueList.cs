using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class PoOverdueList
    {
        public Guid Id { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? StatusId { get; set; }
        public Guid? OrganizationId { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }
        public Guid? BudgetId { get; set; }
        public Guid? AuthorizedById { get; set; }
        public string BillTo { get; set; }
        public string BillToAddress { get; set; }
        public string BillToContact { get; set; }
        public string BillToEmail { get; set; }
        public string BillToFax { get; set; }
        public string BillToPhone { get; set; }
        public DateTime? DateReceived { get; set; }
        public DateTime? DateRequired { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string InvoiceNumber { get; set; }
        public Guid? PaymentTermsId { get; set; }
        public DateTime? PoDate { get; set; }
        public string PoNumber { get; set; }
        public decimal? PriceAdjustment { get; set; }
        public Guid? RequesterId { get; set; }
        public string ShipTo { get; set; }
        public string ShipToAddress { get; set; }
        public string ShipToContact { get; set; }
        public string ShipToEmail { get; set; }
        public string ShipToFax { get; set; }
        public string ShipToPhone { get; set; }
        public Guid? ShippingId { get; set; }
        public decimal? ShippingPrice { get; set; }
        public double? TaxRate { get; set; }
        public string VendorAddress { get; set; }
        public string VendorContact { get; set; }
        public string VendorEmail { get; set; }
        public string VendorFax { get; set; }
        public string VendorFein { get; set; }
        public Guid? VendorId { get; set; }
        public string VendorName { get; set; }
        public string VendorPhone { get; set; }
        public int? Udf0004 { get; set; }
        public string Oid { get; set; }
        public double? ShippingTaxRate { get; set; }
        public decimal? SalesTax { get; set; }
        public Guid? OwnerId { get; set; }
        public Guid? FreightTermsId { get; set; }
        public string Organization { get; set; }
        public string Vendor { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public decimal SubTotal { get; set; }
        public decimal? TotalAmount { get; set; }
        public string Budget { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string Requester { get; set; }
        public string AuthorizedBy { get; set; }
        public string Owner { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? FlagStatus { get; set; }
        public int? Qty { get; set; }
        public int? QtyReceived { get; set; }
        public string PaymentTerms { get; set; }
        public string FreightTerms { get; set; }
        public string Shipping { get; set; }
        public int? QtyRemaining { get; set; }
        public bool Attachments { get; set; }
        public int AttachmentsCount { get; set; }
        public int AttachmentsTotalSize { get; set; }
        public int ActivityCount { get; set; }
        public int LinksCount { get; set; }
    }
}
