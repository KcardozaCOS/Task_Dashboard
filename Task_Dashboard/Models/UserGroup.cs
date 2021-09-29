using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class UserGroup
    {
        public UserGroup()
        {
            ApprovalStages = new HashSet<ApprovalStage>();
            ChangeRequests = new HashSet<ChangeRequest>();
            GroupMembers = new HashSet<GroupMember>();
            Incidents = new HashSet<Incident>();
            Problems = new HashSet<Problem>();
            ServiceRequests = new HashSet<ServiceRequest>();
            Services = new HashSet<Service>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        public Guid Id { get; set; }
        public Guid? ManagerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? StatusId { get; set; }
        public string Oid { get; set; }
        public bool TechniciansOnly { get; set; }

        public virtual Person Manager { get; set; }
        public virtual Status Status { get; set; }
        public virtual ObjectType Type { get; set; }
        public virtual ICollection<ApprovalStage> ApprovalStages { get; set; }
        public virtual ICollection<ChangeRequest> ChangeRequests { get; set; }
        public virtual ICollection<GroupMember> GroupMembers { get; set; }
        public virtual ICollection<Incident> Incidents { get; set; }
        public virtual ICollection<Problem> Problems { get; set; }
        public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
