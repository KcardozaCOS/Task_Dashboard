using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Announcement
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

        public virtual Person Owner { get; set; }
        public virtual Status Status { get; set; }
        public virtual ObjectType Type { get; set; }
    }
}
