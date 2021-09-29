using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ReceiversSlaList
    {
        public Guid Id { get; set; }
        public Guid SlaId { get; set; }
        public Guid ReceiverOrganizationId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string ServiceProviderOrganization { get; set; }
        public string ServiceName { get; set; }
        public string ServiceType { get; set; }
        public string ServiceCategory { get; set; }
        public string ServiceStatus { get; set; }
        public string ServiceManager { get; set; }
        public string ServiceSupportGroup { get; set; }
        public string ServiceLevel { get; set; }
    }
}
