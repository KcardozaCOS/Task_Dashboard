using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class XxsaPersonHolidays3yrWindow
    {
        public Guid? PersonId { get; set; }
        public string Person { get; set; }
        public string PrimaryLogin { get; set; }
        public string FullName { get; set; }
        public Guid? ExceptionId { get; set; }
        public Guid? WorkCalendarId { get; set; }
        public DateTime? ExceptionFrom { get; set; }
        public DateTime? ExceptionTo { get; set; }
        public DateTime? ExceptionDate { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Color { get; set; }
        public DateTime? LunchFrom { get; set; }
        public DateTime? LunchTo { get; set; }
        public DateTime? ExDtFrom { get; set; }
        public DateTime? ExDtTo { get; set; }
        public int? TimeSpent { get; set; }
        public string HoursType { get; set; }
        public string HoursClass { get; set; }
    }
}
