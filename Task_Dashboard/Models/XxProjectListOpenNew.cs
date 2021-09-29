using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class XxProjectListOpenNew
    {
        public string SponsoringOrgs { get; set; }
        public string Requester { get; set; }
        public string ParentProjectId { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Type { get; set; }
        public string Manager { get; set; }
        public string GroupMembership { get; set; }
        public string Status { get; set; }
        public int? Priority { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? EstimatedHours { get; set; }
        public double? TimeSpent { get; set; }
        public string TimeSpentSt { get; set; }
        public string Description { get; set; }
        public string BusinessCase { get; set; }
        public string ImpactedSystems { get; set; }
        public string ImpactedAreas { get; set; }
        public string ResourceCost { get; set; }
        public string Notes { get; set; }
        public string RecType { get; set; }
        public int IsParentProj { get; set; }
        public int IsParentMgr { get; set; }
        public string ParentMgrName { get; set; }
    }
}
