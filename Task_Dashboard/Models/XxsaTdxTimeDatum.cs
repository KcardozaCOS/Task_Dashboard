using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class XxsaTdxTimeDatum
    {
        public int TimeId { get; set; }
        public DateTime? ActivityDate { get; set; }
        public string UserName { get; set; }
        public int? Minutes { get; set; }
        public int? ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string ItemTitle { get; set; }
    }
}
