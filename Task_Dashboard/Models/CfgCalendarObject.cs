using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgCalendarObject
    {
        public Guid Id { get; set; }
        public Guid? PersonId { get; set; }
        public Guid ClassId { get; set; }
        public bool Visible { get; set; }
        public string StartDateField { get; set; }
        public string EndDateField { get; set; }
        public string Filter { get; set; }
        public int? FilterMode { get; set; }
        public string Description { get; set; }

        public virtual ObjectClass Class { get; set; }
        public virtual Person Person { get; set; }
    }
}
