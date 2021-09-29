using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Receiver
    {
        public Guid Id { get; set; }
        public Guid SlaId { get; set; }
        public Guid ReceiverOrganizationId { get; set; }

        public virtual OrganizationalUnit ReceiverOrganization { get; set; }
        public virtual Sla Sla { get; set; }
    }
}
