using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class AnnouncementListActive
    {
        public Guid Id { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool HighPriority { get; set; }
        public bool TechnicianUsers { get; set; }
        public bool SelfServiceUsers { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid? StatusId { get; set; }
        public Guid? TypeId { get; set; }
        public string Oid { get; set; }
        public string Notes { get; set; }
        public Guid? OwnerId { get; set; }
        public string Audience { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public int ActivityCount { get; set; }
        public int? FlagStatus { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string Owner { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int LinksCount { get; set; }
    }
}
