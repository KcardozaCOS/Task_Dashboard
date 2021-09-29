using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ServiceCatalogItem
    {
        public ServiceCatalogItem()
        {
            ScItemCategories = new HashSet<ScItemCategory>();
            ServiceRequests = new HashSet<ServiceRequest>();
        }

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

        public virtual ServiceRequestFulfillment RequestFulfillment { get; set; }
        public virtual Service Service { get; set; }
        public virtual Status Status { get; set; }
        public virtual ObjectType Type { get; set; }
        public virtual ICollection<ScItemCategory> ScItemCategories { get; set; }
        public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }
    }
}
