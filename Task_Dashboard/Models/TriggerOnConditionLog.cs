using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class TriggerOnConditionLog
    {
        public Guid Id { get; set; }
        public Guid? JobId { get; set; }
        public DateTime RunDate { get; set; }
        public string Comments { get; set; }
        public int? Duration { get; set; }
        public int? Updated { get; set; }
        public int? Errors { get; set; }
        public DateTime UploadDate { get; set; }
        public string TriggerName { get; set; }
    }
}
