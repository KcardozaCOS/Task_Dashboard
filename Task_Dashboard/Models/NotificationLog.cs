using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class NotificationLog
    {
        public Guid Id { get; set; }
        public Guid? JobId { get; set; }
        public DateTime RunDate { get; set; }
        public string Comments { get; set; }
        public int? Duration { get; set; }
        public int? Total { get; set; }
        public int? Succeeded { get; set; }
        public int? Errors { get; set; }
        public DateTime UploadDate { get; set; }
    }
}
