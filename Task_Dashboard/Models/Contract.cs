using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Contract
    {
        public Guid Id { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? StatusId { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }
        public string ContractNumber { get; set; }
        public decimal? Cost { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string WarrantyDetails { get; set; }
        public Guid? TypeId { get; set; }
        public string Oid { get; set; }
        public bool RenewalOption { get; set; }
        public Guid? ProviderId { get; set; }
        public Guid? ReceiverId { get; set; }
        public string UdfLocation { get; set; }

        public virtual ObjectCategory Category { get; set; }
        public virtual OrganizationalUnit Provider { get; set; }
        public virtual OrganizationalUnit Receiver { get; set; }
        public virtual Status Status { get; set; }
        public virtual ObjectType Type { get; set; }
    }
}
