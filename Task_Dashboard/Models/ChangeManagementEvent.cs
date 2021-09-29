using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ChangeManagementEvent
    {
        public Guid Id { get; set; }
        public Guid ManagementProcessId { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
        public int Color { get; set; }
        public string Description { get; set; }
    }
}
