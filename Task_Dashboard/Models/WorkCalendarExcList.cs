using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class WorkCalendarExcList
    {
        public Guid Id { get; set; }
        public Guid WorkCalendarId { get; set; }
        public string Name { get; set; }
        public int ExceptionType { get; set; }
        public DateTime? ExceptionDate { get; set; }
        public string Description { get; set; }
        public int? Color { get; set; }
        public bool? IsWorkingTime { get; set; }
        public DateTime? DtFrom { get; set; }
        public DateTime? DtTo { get; set; }
        public int? AllDay { get; set; }
    }
}
