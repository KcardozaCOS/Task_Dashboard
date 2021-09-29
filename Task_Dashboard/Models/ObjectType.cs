using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ObjectType
    {
        public ObjectType()
        {
            Announcements = new HashSet<Announcement>();
            ApprovalRequests = new HashSet<ApprovalRequest>();
            ApprovalStages = new HashSet<ApprovalStage>();
            Assets = new HashSet<Asset>();
            ChangeRequestApprovals = new HashSet<ChangeRequestApproval>();
            ChangeRequests = new HashSet<ChangeRequest>();
            Computers = new HashSet<Computer>();
            Configurations = new HashSet<Configuration>();
            Consumables = new HashSet<Consumable>();
            Contracts = new HashSet<Contract>();
            Documents = new HashSet<Document>();
            Hardwares = new HashSet<Hardware>();
            Incidents = new HashSet<Incident>();
            KbArticles = new HashSet<KbArticle>();
            Libraries = new HashSet<Library>();
            Locations = new HashSet<Location>();
            Networks = new HashSet<Network>();
            ObjectIndices = new HashSet<ObjectIndex>();
            OrganizationalUnits = new HashSet<OrganizationalUnit>();
            People = new HashSet<Person>();
            PoItemAssetTypes = new HashSet<PoItem>();
            PoItemComputerTypes = new HashSet<PoItem>();
            PoItemConsumableTypes = new HashSet<PoItem>();
            PoItemHardwareTypes = new HashSet<PoItem>();
            PoItemSoftwareLicenseTypes = new HashSet<PoItem>();
            PoItemTypes = new HashSet<PoItem>();
            Pos = new HashSet<Po>();
            Problems = new HashSet<Problem>();
            ProductAssetTypes = new HashSet<Product>();
            ProductComputerTypes = new HashSet<Product>();
            ProductConsumableTypes = new HashSet<Product>();
            ProductHardwareTypes = new HashSet<Product>();
            ProductSoftwareLicenseTypes = new HashSet<Product>();
            ProductTypes = new HashSet<Product>();
            Projects = new HashSet<Project>();
            Reservations = new HashSet<Reservation>();
            ServiceCatalogItems = new HashSet<ServiceCatalogItem>();
            ServiceRequests = new HashSet<ServiceRequest>();
            Services = new HashSet<Service>();
            Slas = new HashSet<Sla>();
            SoftwareLicenses = new HashSet<SoftwareLicense>();
            StockRules = new HashSet<StockRule>();
            TrackedSoftwares = new HashSet<TrackedSoftware>();
            UserGroups = new HashSet<UserGroup>();
            VendorProducts = new HashSet<VendorProduct>();
            Vendors = new HashSet<Vendor>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        public Guid Id { get; set; }
        public Guid ClassId { get; set; }
        public string Type { get; set; }
        public int? Rank { get; set; }
        public bool System { get; set; }
        public bool Active { get; set; }
        public string Tags { get; set; }

        public virtual ObjectClass Class { get; set; }
        public virtual ICollection<Announcement> Announcements { get; set; }
        public virtual ICollection<ApprovalRequest> ApprovalRequests { get; set; }
        public virtual ICollection<ApprovalStage> ApprovalStages { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
        public virtual ICollection<ChangeRequestApproval> ChangeRequestApprovals { get; set; }
        public virtual ICollection<ChangeRequest> ChangeRequests { get; set; }
        public virtual ICollection<Computer> Computers { get; set; }
        public virtual ICollection<Configuration> Configurations { get; set; }
        public virtual ICollection<Consumable> Consumables { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Hardware> Hardwares { get; set; }
        public virtual ICollection<Incident> Incidents { get; set; }
        public virtual ICollection<KbArticle> KbArticles { get; set; }
        public virtual ICollection<Library> Libraries { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<Network> Networks { get; set; }
        public virtual ICollection<ObjectIndex> ObjectIndices { get; set; }
        public virtual ICollection<OrganizationalUnit> OrganizationalUnits { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<PoItem> PoItemAssetTypes { get; set; }
        public virtual ICollection<PoItem> PoItemComputerTypes { get; set; }
        public virtual ICollection<PoItem> PoItemConsumableTypes { get; set; }
        public virtual ICollection<PoItem> PoItemHardwareTypes { get; set; }
        public virtual ICollection<PoItem> PoItemSoftwareLicenseTypes { get; set; }
        public virtual ICollection<PoItem> PoItemTypes { get; set; }
        public virtual ICollection<Po> Pos { get; set; }
        public virtual ICollection<Problem> Problems { get; set; }
        public virtual ICollection<Product> ProductAssetTypes { get; set; }
        public virtual ICollection<Product> ProductComputerTypes { get; set; }
        public virtual ICollection<Product> ProductConsumableTypes { get; set; }
        public virtual ICollection<Product> ProductHardwareTypes { get; set; }
        public virtual ICollection<Product> ProductSoftwareLicenseTypes { get; set; }
        public virtual ICollection<Product> ProductTypes { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<ServiceCatalogItem> ServiceCatalogItems { get; set; }
        public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<Sla> Slas { get; set; }
        public virtual ICollection<SoftwareLicense> SoftwareLicenses { get; set; }
        public virtual ICollection<StockRule> StockRules { get; set; }
        public virtual ICollection<TrackedSoftware> TrackedSoftwares { get; set; }
        public virtual ICollection<UserGroup> UserGroups { get; set; }
        public virtual ICollection<VendorProduct> VendorProducts { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
