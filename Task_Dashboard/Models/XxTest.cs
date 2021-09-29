using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class XxTest
    {
        public string Summary { get; set; }
        public string Ticket { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public double? TimeSpent { get; set; }
        public string Details { get; set; }
    }
}
