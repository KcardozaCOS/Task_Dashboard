using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ObjectIndex
    {
        public ObjectIndex()
        {
            Activities = new HashSet<Activity>();
            ApprovalStages = new HashSet<ApprovalStage>();
            Assets = new HashSet<Asset>();
            CfgWorkOrderParentChildren = new HashSet<CfgWorkOrderParent>();
            CfgWorkOrderParentParents = new HashSet<CfgWorkOrderParent>();
            ChangeRequests = new HashSet<ChangeRequest>();
            Configurations = new HashSet<Configuration>();
            DetectedSoftwareProducts = new HashSet<DetectedSoftwareProduct>();
            Histories = new HashSet<History>();
            Incidents = new HashSet<Incident>();
            IpAddressLinks = new HashSet<IpAddressLink>();
            LicenseAllocations = new HashSet<LicenseAllocation>();
            ObjectAttachments = new HashSet<ObjectAttachment>();
            ObjectFlags = new HashSet<ObjectFlag>();
            ObjectRelationLeftObjects = new HashSet<ObjectRelation>();
            ObjectRelationRightObjects = new HashSet<ObjectRelation>();
            Problems = new HashSet<Problem>();
            ServiceRequests = new HashSet<ServiceRequest>();
            SolutionRatings = new HashSet<SolutionRating>();
            WorkOrderParents = new HashSet<WorkOrder>();
            WorkOrderRelatedCis = new HashSet<WorkOrder>();
        }

        public Guid Id { get; set; }
        public Guid ClassId { get; set; }
        public string ObjectName { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? Counter1 { get; set; }
        public int? Counter2 { get; set; }
        public string Oid { get; set; }
        public Guid? StatusId { get; set; }
        public Guid? TypeId { get; set; }

        public virtual ObjectClass Class { get; set; }
        public virtual Status Status { get; set; }
        public virtual ObjectType Type { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<ApprovalStage> ApprovalStages { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
        public virtual ICollection<CfgWorkOrderParent> CfgWorkOrderParentChildren { get; set; }
        public virtual ICollection<CfgWorkOrderParent> CfgWorkOrderParentParents { get; set; }
        public virtual ICollection<ChangeRequest> ChangeRequests { get; set; }
        public virtual ICollection<Configuration> Configurations { get; set; }
        public virtual ICollection<DetectedSoftwareProduct> DetectedSoftwareProducts { get; set; }
        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<Incident> Incidents { get; set; }
        public virtual ICollection<IpAddressLink> IpAddressLinks { get; set; }
        public virtual ICollection<LicenseAllocation> LicenseAllocations { get; set; }
        public virtual ICollection<ObjectAttachment> ObjectAttachments { get; set; }
        public virtual ICollection<ObjectFlag> ObjectFlags { get; set; }
        public virtual ICollection<ObjectRelation> ObjectRelationLeftObjects { get; set; }
        public virtual ICollection<ObjectRelation> ObjectRelationRightObjects { get; set; }
        public virtual ICollection<Problem> Problems { get; set; }
        public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }
        public virtual ICollection<SolutionRating> SolutionRatings { get; set; }
        public virtual ICollection<WorkOrder> WorkOrderParents { get; set; }
        public virtual ICollection<WorkOrder> WorkOrderRelatedCis { get; set; }
    }
}
