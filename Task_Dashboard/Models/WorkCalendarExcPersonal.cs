using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class WorkCalendarExcPersonal
    {
        public Guid Id { get; set; }
        public Guid? PersonId { get; set; }
        public Guid WorkCalendarId { get; set; }
        public string Name { get; set; }
        public DateTime? FromTime { get; set; }
        public DateTime? ToTime { get; set; }
        public bool? IsWorkTime { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
        public string Category { get; set; }
        public bool AllDay { get; set; }
        public bool? Available { get; set; }
    }
}
