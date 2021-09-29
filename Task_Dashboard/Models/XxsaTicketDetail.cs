using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class XxsaTicketDetail
    {
        public string Login { get; set; }
        public DateTime? PeriodStart { get; set; }
        public int? Period { get; set; }
        public int? PpDay { get; set; }
        public DateTime? ActivityDate { get; set; }
        public string HoursType { get; set; }
        public string Project { get; set; }
        public string Task { get; set; }
        public string Ticket { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public double? TimeSpent { get; set; }
        public string ActTimeSpent { get; set; }
        public double? TicketTime { get; set; }
        public string ActTimeTicket { get; set; }
        public double? RepTime { get; set; }
        public string ActTimeRep { get; set; }
    }
}
