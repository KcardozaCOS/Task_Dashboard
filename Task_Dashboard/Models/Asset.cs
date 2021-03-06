using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Asset
    {
        public Asset()
        {
            Libraries = new HashSet<Library>();
        }

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
        public Guid? AssociatedCiId { get; set; }
        public string Notes { get; set; }
        public Guid? DepreciationMethodId { get; set; }
        public bool? Lease { get; set; }
        public DateTime? LeaseReturnDate { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal? Price { get; set; }
        public decimal? SalvageValue { get; set; }
        public int? Lifespan { get; set; }
        public string PurchaseOrder { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string AssetTag { get; set; }
        public string Barcode { get; set; }
        public decimal? UnitCost { get; set; }
        public int? Qty { get; set; }
        public decimal? CurrentValue { get; set; }
        public DateTime? LastDepreciation { get; set; }
        public string SerialNum { get; set; }
        public Guid? ManufacturerId { get; set; }
        public string Model { get; set; }
        public string Version { get; set; }
        public string PartNumber { get; set; }
        public string Sku { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public DateTime? RetirementDate { get; set; }
        public Guid? PoItemId { get; set; }
        public DateTime? WarrantyExp { get; set; }
        public Guid? VendorId { get; set; }
        public Guid? ProductId { get; set; }
        public Guid? StockRoomId { get; set; }

        public virtual ObjectIndex AssociatedCi { get; set; }
        public virtual ObjectCategory Category { get; set; }
        public virtual DepreciationMethod DepreciationMethod { get; set; }
        public virtual Location Location { get; set; }
        public virtual Brand Manufacturer { get; set; }
        public virtual OrganizationalUnit Organization { get; set; }
        public virtual Person Owner { get; set; }
        public virtual PoItem PoItem { get; set; }
        public virtual Product Product { get; set; }
        public virtual Status Status { get; set; }
        public virtual StockRoom StockRoom { get; set; }
        public virtual ObjectType Type { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<Library> Libraries { get; set; }
    }
}
