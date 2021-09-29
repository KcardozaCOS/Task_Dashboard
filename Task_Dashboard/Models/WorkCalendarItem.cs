using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class WorkCalendarItem
    {
        public Guid Id { get; set; }
        public Guid WorkCalendarId { get; set; }
        public Guid WorkingHoursId { get; set; }
        public int DayNumber { get; set; }

        public virtual WorkCalendar WorkCalendar { get; set; }
        public virtual WorkCalendarHour WorkingHours { get; set; }
    }
}
