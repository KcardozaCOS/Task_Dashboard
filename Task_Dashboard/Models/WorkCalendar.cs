using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class WorkCalendar
    {
        public WorkCalendar()
        {
            People = new HashSet<Person>();
            ServiceLevels = new HashSet<ServiceLevel>();
            Services = new HashSet<Service>();
            WorkCalendarExceptions = new HashSet<WorkCalendarException>();
            WorkCalendarItems = new HashSet<WorkCalendarItem>();
            WorkCalendarParentParents = new HashSet<WorkCalendarParent>();
            WorkCalendarParentWorkCalendars = new HashSet<WorkCalendarParent>();
        }

        public Guid Id { get; set; }
        public bool Default { get; set; }
        public int CalendarType { get; set; }
        public int? DayFrequency { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? PersonId { get; set; }

        public virtual Person Person { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<ServiceLevel> ServiceLevels { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<WorkCalendarException> WorkCalendarExceptions { get; set; }
        public virtual ICollection<WorkCalendarItem> WorkCalendarItems { get; set; }
        public virtual ICollection<WorkCalendarParent> WorkCalendarParentParents { get; set; }
        public virtual ICollection<WorkCalendarParent> WorkCalendarParentWorkCalendars { get; set; }
    }
}
