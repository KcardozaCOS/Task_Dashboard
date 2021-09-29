using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class XxsaHistory3
    {
        public Guid Id { get; set; }
        public Guid ObjectId { get; set; }
        public Guid? RefObjectId { get; set; }
        public string ChangedBy { get; set; }
        public Guid? ChangedById { get; set; }
        public DateTime? EffectiveStartDate { get; set; }
        public DateTime? EffectiveEndDate { get; set; }
        public int? Duration { get; set; }
        public string Action { get; set; }
        public string Attribute { get; set; }
        public string Value { get; set; }
        public string WfItemNum { get; set; }
    }
}
