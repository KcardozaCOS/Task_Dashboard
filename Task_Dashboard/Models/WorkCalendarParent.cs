using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class WorkCalendarParent
    {
        public Guid Id { get; set; }
        public Guid WorkCalendarId { get; set; }
        public Guid ParentId { get; set; }
        public int? Rank { get; set; }

        public virtual WorkCalendar Parent { get; set; }
        public virtual WorkCalendar WorkCalendar { get; set; }
    }
}
