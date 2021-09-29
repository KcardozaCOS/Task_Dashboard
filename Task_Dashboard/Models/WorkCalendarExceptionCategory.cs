using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class WorkCalendarExceptionCategory
    {
        public WorkCalendarExceptionCategory()
        {
            WorkCalendarExceptions = new HashSet<WorkCalendarException>();
        }

        public Guid Id { get; set; }
        public string Category { get; set; }
        public bool AllDay { get; set; }
        public bool IsWorkingTime { get; set; }
        public bool Available { get; set; }
        public int Color { get; set; }
        public bool Active { get; set; }
        public bool System { get; set; }
        public int? Rank { get; set; }

        public virtual ICollection<WorkCalendarException> WorkCalendarExceptions { get; set; }
    }
}
