using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CiAndTicketObjectClass
    {
        public Guid Id { get; set; }
        public bool Ci { get; set; }
        public bool Organization { get; set; }
        public string Description { get; set; }
        public string TableName { get; set; }
        public int ClassIndex { get; set; }
        public string Class { get; set; }
    }
}
