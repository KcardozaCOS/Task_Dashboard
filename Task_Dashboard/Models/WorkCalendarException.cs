using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class WorkCalendarException
    {
        public Guid Id { get; set; }
        public Guid WorkCalendarId { get; set; }
        public int ExceptionType { get; set; }
        public string Name { get; set; }
        public DateTime? ExceptionDate { get; set; }
        public Guid? WorkingHoursId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? StopTime { get; set; }
        public int? DateType { get; set; }
        public int? DayNumber { get; set; }
        public int? WeekNumber { get; set; }
        public int? MonthNumber { get; set; }
        public bool AllDay { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }

        public virtual WorkCalendarExceptionCategory Category { get; set; }
        public virtual WorkCalendar WorkCalendar { get; set; }
        public virtual WorkCalendarHour WorkingHours { get; set; }
    }
}
