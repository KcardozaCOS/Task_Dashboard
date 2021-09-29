using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class RecurrentTicketLog
    {
        public Guid Id { get; set; }
        public Guid? JobId { get; set; }
        public DateTime RunDate { get; set; }
        public string Comments { get; set; }
        public int? Duration { get; set; }
        public Guid LceventsId { get; set; }
        public string TicketNum { get; set; }
        public string CreatedBy { get; set; }
        public int? Errors { get; set; }
        public DateTime UploadDate { get; set; }
        public string ActionName { get; set; }
    }
}
