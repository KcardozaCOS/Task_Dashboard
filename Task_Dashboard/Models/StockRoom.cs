using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class StockRoom
    {
        public StockRoom()
        {
            Assets = new HashSet<Asset>();
            Consumables = new HashSet<Consumable>();
            PoItems = new HashSet<PoItem>();
            StockRules = new HashSet<StockRule>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? LocationId { get; set; }
        public Guid? ManagerId { get; set; }
        public string Notes { get; set; }

        public virtual Location Location { get; set; }
        public virtual Person Manager { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
        public virtual ICollection<Consumable> Consumables { get; set; }
        public virtual ICollection<PoItem> PoItems { get; set; }
        public virtual ICollection<StockRule> StockRules { get; set; }
    }
}
