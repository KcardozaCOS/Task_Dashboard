using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Vendor
    {
        public Vendor()
        {
            Assets = new HashSet<Asset>();
            Consumables = new HashSet<Consumable>();
            Pos = new HashSet<Po>();
            VendorProducts = new HashSet<VendorProduct>();
        }

        public Guid Id { get; set; }
        public Guid? CategoryId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        public string WebPage { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Fein { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? StatusId { get; set; }
        public string Oid { get; set; }
        public string Contact { get; set; }
        public bool Preferred { get; set; }
        public Guid? ManagerId { get; set; }
        public string Udf0001 { get; set; }
        public string Udf0002 { get; set; }

        public virtual ObjectCategory Category { get; set; }
        public virtual Person Manager { get; set; }
        public virtual Status Status { get; set; }
        public virtual ObjectType Type { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
        public virtual ICollection<Consumable> Consumables { get; set; }
        public virtual ICollection<Po> Pos { get; set; }
        public virtual ICollection<VendorProduct> VendorProducts { get; set; }
    }
}
