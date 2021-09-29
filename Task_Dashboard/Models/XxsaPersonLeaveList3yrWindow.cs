using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class XxsaPersonLeaveList3yrWindow
    {
        public Guid? ExceptionId { get; set; }
        public int? Num { get; set; }
        public Guid? LeaveUsedById { get; set; }
        public string LeaveUsedBy { get; set; }
        public DateTime? LeaveDate { get; set; }
        public double? TimeSpent { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CityHoliday { get; set; }
        public int PersonalLeave { get; set; }
        public Guid? WorkCalendarId { get; set; }
        public Guid? CategoryId { get; set; }
        public string Category { get; set; }
        public string HoursType { get; set; }
        public string HoursClass { get; set; }
    }
}
