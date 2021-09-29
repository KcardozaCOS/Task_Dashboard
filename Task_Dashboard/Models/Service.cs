using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Service
    {
        public Service()
        {
            ChangeRequests = new HashSet<ChangeRequest>();
            Incidents = new HashSet<Incident>();
            Problems = new HashSet<Problem>();
            ServiceCatalogItems = new HashSet<ServiceCatalogItem>();
            ServiceLevels = new HashSet<ServiceLevel>();
            ServiceRequests = new HashSet<ServiceRequest>();
            Slas = new HashSet<Sla>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        public Guid Id { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? StatusId { get; set; }
        public string Name { get; set; }
        public Guid? ServiceManagerId { get; set; }
        public Guid? SupportGroupId { get; set; }
        public string Notes { get; set; }
        public string Oid { get; set; }
        public Guid TicketClassId { get; set; }
        public string Description { get; set; }
        public Guid? ServiceProviderId { get; set; }
        public Guid? AvailabilityHoursId { get; set; }
        public int? UdfEstEffort { get; set; }
        public double? UdfExpCommit { get; set; }

        public virtual WorkCalendar AvailabilityHours { get; set; }
        public virtual ObjectCategory Category { get; set; }
        public virtual Person ServiceManager { get; set; }
        public virtual OrganizationalUnit ServiceProvider { get; set; }
        public virtual Status Status { get; set; }
        public virtual UserGroup SupportGroup { get; set; }
        public virtual ObjectClass TicketClass { get; set; }
        public virtual ObjectType Type { get; set; }
        public virtual ICollection<ChangeRequest> ChangeRequests { get; set; }
        public virtual ICollection<Incident> Incidents { get; set; }
        public virtual ICollection<Problem> Problems { get; set; }
        public virtual ICollection<ServiceCatalogItem> ServiceCatalogItems { get; set; }
        public virtual ICollection<ServiceLevel> ServiceLevels { get; set; }
        public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }
        public virtual ICollection<Sla> Slas { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
