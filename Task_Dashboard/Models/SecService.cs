using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SecService
    {
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
    }
}
