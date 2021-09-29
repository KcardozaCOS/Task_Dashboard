using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class WorkCalendarItemList
    {
        public Guid WorkCalendarId { get; set; }
        public Guid WorkingHoursId { get; set; }
        public int DayNumber { get; set; }
        public DateTime? DtFrom { get; set; }
        public DateTime? DtTo { get; set; }
        public int? IsWorkingTime { get; set; }
    }
}
