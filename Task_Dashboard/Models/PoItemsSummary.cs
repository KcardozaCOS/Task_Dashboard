using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class PoItemsSummary
    {
        public Guid Id { get; set; }
        public decimal? SubTotal { get; set; }
        public int? Qty { get; set; }
        public int? QtyReceived { get; set; }
    }
}
