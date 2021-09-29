using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class StockRoomList
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? LocationId { get; set; }
        public Guid? ManagerId { get; set; }
        public string Notes { get; set; }
        public string Location { get; set; }
        public string Manager { get; set; }
    }
}
