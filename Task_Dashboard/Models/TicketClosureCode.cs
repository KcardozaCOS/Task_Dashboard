using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class TicketClosureCode
    {
        public TicketClosureCode()
        {
            ChangeRequests = new HashSet<ChangeRequest>();
            Incidents = new HashSet<Incident>();
            Problems = new HashSet<Problem>();
            ServiceRequests = new HashSet<ServiceRequest>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        public Guid Id { get; set; }
        public Guid ClassId { get; set; }
        public string ClosureCode { get; set; }
        public bool Default { get; set; }
        public bool System { get; set; }
        public int? Rank { get; set; }
        public bool Active { get; set; }
        public string Tags { get; set; }

        public virtual ObjectClass Class { get; set; }
        public virtual ICollection<ChangeRequest> ChangeRequests { get; set; }
        public virtual ICollection<Incident> Incidents { get; set; }
        public virtual ICollection<Problem> Problems { get; set; }
        public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
