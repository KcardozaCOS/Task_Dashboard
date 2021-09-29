using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class StockMovementReason
    {
        public StockMovementReason()
        {
            StockMovements = new HashSet<StockMovement>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Direction { get; set; }
        public int? Rank { get; set; }
        public bool System { get; set; }
        public bool Active { get; set; }
        public string Tags { get; set; }

        public virtual ICollection<StockMovement> StockMovements { get; set; }
    }
}
