using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class WorkCalendarHour
    {
        public WorkCalendarHour()
        {
            WorkCalendarExceptions = new HashSet<WorkCalendarException>();
            WorkCalendarItems = new HashSet<WorkCalendarItem>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }
        public bool DayOff { get; set; }

        public virtual ICollection<WorkCalendarException> WorkCalendarExceptions { get; set; }
        public virtual ICollection<WorkCalendarItem> WorkCalendarItems { get; set; }
    }
}
