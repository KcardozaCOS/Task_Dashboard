using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Assets = new HashSet<Asset>();
            Computers = new HashSet<Computer>();
            Consumables = new HashSet<Consumable>();
            Hardwares = new HashSet<Hardware>();
            Products = new HashSet<Product>();
            SoftProducts = new HashSet<SoftProduct>();
        }

        public Guid Id { get; set; }
        public Guid? OrganizationId { get; set; }
        public string Brand1 { get; set; }
        public string WebPage { get; set; }
        public bool Active { get; set; }

        public virtual OrganizationalUnit Organization { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
        public virtual ICollection<Computer> Computers { get; set; }
        public virtual ICollection<Consumable> Consumables { get; set; }
        public virtual ICollection<Hardware> Hardwares { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<SoftProduct> SoftProducts { get; set; }
    }
}
