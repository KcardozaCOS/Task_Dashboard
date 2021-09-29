using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ProjectListActive
    {
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
        public string Manager { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public bool Attachments { get; set; }
        public int AttachmentsCount { get; set; }
        public int AttachmentsTotalSize { get; set; }
        public int ActivityCount { get; set; }
        public int TicketsCount { get; set; }
        public int? FlagStatus { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int LinksCount { get; set; }
    }
}
