using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ServiceRequestFulfillment
    {
        public ServiceRequestFulfillment()
        {
            ServiceCatalogItems = new HashSet<ServiceCatalogItem>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? RequestCreateActionId { get; set; }
        public int? Rank { get; set; }
        public bool System { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<ServiceCatalogItem> ServiceCatalogItems { get; set; }
    }
}
