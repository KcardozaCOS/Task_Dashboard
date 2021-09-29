using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ServiceLevel
    {
        public ServiceLevel()
        {
            PriorityCalculations = new HashSet<PriorityCalculation>();
            ResponseTimes = new HashSet<ResponseTime>();
            Slas = new HashSet<Sla>();
        }

        public Guid Id { get; set; }
        public string ServiceLevel1 { get; set; }
        public bool System { get; set; }
        public int? Rank { get; set; }
        public Guid ServiceId { get; set; }
        public Guid? SupportHoursId { get; set; }
        public string Description { get; set; }

        public virtual Service Service { get; set; }
        public virtual WorkCalendar SupportHours { get; set; }
        public virtual ICollection<PriorityCalculation> PriorityCalculations { get; set; }
        public virtual ICollection<ResponseTime> ResponseTimes { get; set; }
        public virtual ICollection<Sla> Slas { get; set; }
    }
}
