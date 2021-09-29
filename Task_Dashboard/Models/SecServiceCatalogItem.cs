using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SecServiceCatalogItem
    {
        public Guid Id { get; set; }
        public string Oid { get; set; }
        public string Name { get; set; }
        public Guid? RequestFulfillmentId { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? StatusId { get; set; }
        public decimal? Price { get; set; }
        public byte[] Picture { get; set; }
        public string Details { get; set; }
        public string Description { get; set; }
        public Guid? ServiceId { get; set; }
        public string Notes { get; set; }
    }
}
