using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class VendorProduct
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

        public virtual Product Product { get; set; }
        public virtual Status Status { get; set; }
        public virtual ObjectType Type { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
