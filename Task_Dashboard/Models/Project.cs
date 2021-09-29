using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Project
    {
        public Project()
        {
            CfgProjectParentChildren = new HashSet<CfgProjectParent>();
            CfgProjectParentParents = new HashSet<CfgProjectParent>();
            ChangeRequests = new HashSet<ChangeRequest>();
            Incidents = new HashSet<Incident>();
            InverseParent = new HashSet<Project>();
            Problems = new HashSet<Problem>();
            ServiceRequests = new HashSet<ServiceRequest>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public string Name { get; set; }
        public string Placement { get; set; }
        public string Notes { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? StatusId { get; set; }
        public string Oid { get; set; }
        public Guid? ManagerId { get; set; }
        public double? TimeSpent { get; set; }
        public string UdfImpactedAreas { get; set; }
        public int? UdfPriority { get; set; }
        public string UdfImpactedSystems { get; set; }
        public string UdfBusinessCase { get; set; }
        public string UdfDescription { get; set; }
        public string UdfResourceCost { get; set; }
        public string UdfRequester { get; set; }
        public Guid? UdfRequesterId { get; set; }
        public DateTime? ScheduledStartDate { get; set; }
        public DateTime? ScheduledEndDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? UdfEstEffort { get; set; }
        public double? UdfExpCommit { get; set; }
        public string UdfProjectSponsor { get; set; }
        public Guid? UdfProjectSponsorId { get; set; }
        public string UdfProjectContact { get; set; }
        public Guid? UdfProjectContactId { get; set; }
        public bool UdfSpaInd { get; set; }
        public string UdfXmlData { get; set; }

        public virtual Person Manager { get; set; }
        public virtual Project Parent { get; set; }
        public virtual Status Status { get; set; }
        public virtual ObjectType Type { get; set; }
        public virtual Person UdfProjectContactNavigation { get; set; }
        public virtual Person UdfProjectSponsorNavigation { get; set; }
        public virtual Person UdfRequesterNavigation { get; set; }
        public virtual ICollection<CfgProjectParent> CfgProjectParentChildren { get; set; }
        public virtual ICollection<CfgProjectParent> CfgProjectParentParents { get; set; }
        public virtual ICollection<ChangeRequest> ChangeRequests { get; set; }
        public virtual ICollection<Incident> Incidents { get; set; }
        public virtual ICollection<Project> InverseParent { get; set; }
        public virtual ICollection<Problem> Problems { get; set; }
        public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
