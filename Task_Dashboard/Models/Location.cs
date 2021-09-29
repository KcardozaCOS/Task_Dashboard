using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Location
    {
        public Location()
        {
            Assets = new HashSet<Asset>();
            CfgLocationParentChildren = new HashSet<CfgLocationParent>();
            CfgLocationParentParents = new HashSet<CfgLocationParent>();
            Computers = new HashSet<Computer>();
            Configurations = new HashSet<Configuration>();
            Consumables = new HashSet<Consumable>();
            Documents = new HashSet<Document>();
            Hardwares = new HashSet<Hardware>();
            InverseParent = new HashSet<Location>();
            Networks = new HashSet<Network>();
            OrganizationalUnits = new HashSet<OrganizationalUnit>();
            People = new HashSet<Person>();
            SoftwareLicenseLocations = new HashSet<SoftwareLicenseLocation>();
            SoftwareLicenses = new HashSet<SoftwareLicense>();
            StockRooms = new HashSet<StockRoom>();
            TrackedSoftwares = new HashSet<TrackedSoftware>();
        }

        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? TypeId { get; set; }
        public string Location1 { get; set; }
        public string Placement { get; set; }
        public string Address { get; set; }
        public string TimeZone { get; set; }
        public string Notes { get; set; }
        public Guid? StatusId { get; set; }
        public string Oid { get; set; }
        public Guid? ManagerId { get; set; }

        public virtual Person Manager { get; set; }
        public virtual Location Parent { get; set; }
        public virtual Status Status { get; set; }
        public virtual ObjectType Type { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
        public virtual ICollection<CfgLocationParent> CfgLocationParentChildren { get; set; }
        public virtual ICollection<CfgLocationParent> CfgLocationParentParents { get; set; }
        public virtual ICollection<Computer> Computers { get; set; }
        public virtual ICollection<Configuration> Configurations { get; set; }
        public virtual ICollection<Consumable> Consumables { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Hardware> Hardwares { get; set; }
        public virtual ICollection<Location> InverseParent { get; set; }
        public virtual ICollection<Network> Networks { get; set; }
        public virtual ICollection<OrganizationalUnit> OrganizationalUnits { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<SoftwareLicenseLocation> SoftwareLicenseLocations { get; set; }
        public virtual ICollection<SoftwareLicense> SoftwareLicenses { get; set; }
        public virtual ICollection<StockRoom> StockRooms { get; set; }
        public virtual ICollection<TrackedSoftware> TrackedSoftwares { get; set; }
    }
}
