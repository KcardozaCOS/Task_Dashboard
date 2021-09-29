using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class UnitsOfMeasure
    {
        public UnitsOfMeasure()
        {
            Consumables = new HashSet<Consumable>();
            PoItemPurchasingUoms = new HashSet<PoItem>();
            PoItemStockingUoms = new HashSet<PoItem>();
            ProductPurchasingUoms = new HashSet<Product>();
            ProductStockingUoms = new HashSet<Product>();
        }

        public Guid Id { get; set; }
        public string Unit { get; set; }
        public int? Rank { get; set; }
        public bool System { get; set; }
        public bool Active { get; set; }
        public string Tags { get; set; }

        public virtual ICollection<Consumable> Consumables { get; set; }
        public virtual ICollection<PoItem> PoItemPurchasingUoms { get; set; }
        public virtual ICollection<PoItem> PoItemStockingUoms { get; set; }
        public virtual ICollection<Product> ProductPurchasingUoms { get; set; }
        public virtual ICollection<Product> ProductStockingUoms { get; set; }
    }
}
