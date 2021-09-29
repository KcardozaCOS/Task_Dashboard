using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ObjectCategory
    {
        public ObjectCategory()
        {
            Activities = new HashSet<Activity>();
            ApprovalStages = new HashSet<ApprovalStage>();
            Assets = new HashSet<Asset>();
            CfgObjectCategoryParentChildren = new HashSet<CfgObjectCategoryParent>();
            CfgObjectCategoryParentParents = new HashSet<CfgObjectCategoryParent>();
            ChangeRequests = new HashSet<ChangeRequest>();
            Computers = new HashSet<Computer>();
            Configurations = new HashSet<Configuration>();
            Consumables = new HashSet<Consumable>();
            Contracts = new HashSet<Contract>();
            Documents = new HashSet<Document>();
            Hardwares = new HashSet<Hardware>();
            Incidents = new HashSet<Incident>();
            InverseParent = new HashSet<ObjectCategory>();
            Networks = new HashSet<Network>();
            OrganizationalUnits = new HashSet<OrganizationalUnit>();
            PoItemAssetCategories = new HashSet<PoItem>();
            PoItemCategories = new HashSet<PoItem>();
            PoItemComputerCategories = new HashSet<PoItem>();
            PoItemConsumableCategories = new HashSet<PoItem>();
            PoItemHardwareCategories = new HashSet<PoItem>();
            PoItemSoftwareLicenseCategories = new HashSet<PoItem>();
            Pos = new HashSet<Po>();
            Problems = new HashSet<Problem>();
            ProductAssetCategories = new HashSet<Product>();
            ProductCategories = new HashSet<Product>();
            ProductComputerCategories = new HashSet<Product>();
            ProductConsumableCategories = new HashSet<Product>();
            ProductHardwareCategories = new HashSet<Product>();
            ProductSoftwareLicenseCategories = new HashSet<Product>();
            ServiceRequests = new HashSet<ServiceRequest>();
            Services = new HashSet<Service>();
            Slas = new HashSet<Sla>();
            SoftwareLicenses = new HashSet<SoftwareLicense>();
            StockRules = new HashSet<StockRule>();
            TrackedSoftwares = new HashSet<TrackedSoftware>();
            Vendors = new HashSet<Vendor>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        public Guid Id { get; set; }
        public Guid ClassId { get; set; }
        public Guid? ParentId { get; set; }
        public string Category { get; set; }
        public int? Rank { get; set; }
        public bool System { get; set; }
        public string FullName { get; set; }
        public bool Public { get; set; }
        public bool Active { get; set; }
        public string Tags { get; set; }
        public Guid? SubClassId { get; set; }
        public bool ReadOnly { get; set; }

        public virtual ObjectClass Class { get; set; }
        public virtual ObjectCategory Parent { get; set; }
        public virtual ObjectClass SubClass { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<ApprovalStage> ApprovalStages { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
        public virtual ICollection<CfgObjectCategoryParent> CfgObjectCategoryParentChildren { get; set; }
        public virtual ICollection<CfgObjectCategoryParent> CfgObjectCategoryParentParents { get; set; }
        public virtual ICollection<ChangeRequest> ChangeRequests { get; set; }
        public virtual ICollection<Computer> Computers { get; set; }
        public virtual ICollection<Configuration> Configurations { get; set; }
        public virtual ICollection<Consumable> Consumables { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Hardware> Hardwares { get; set; }
        public virtual ICollection<Incident> Incidents { get; set; }
        public virtual ICollection<ObjectCategory> InverseParent { get; set; }
        public virtual ICollection<Network> Networks { get; set; }
        public virtual ICollection<OrganizationalUnit> OrganizationalUnits { get; set; }
        public virtual ICollection<PoItem> PoItemAssetCategories { get; set; }
        public virtual ICollection<PoItem> PoItemCategories { get; set; }
        public virtual ICollection<PoItem> PoItemComputerCategories { get; set; }
        public virtual ICollection<PoItem> PoItemConsumableCategories { get; set; }
        public virtual ICollection<PoItem> PoItemHardwareCategories { get; set; }
        public virtual ICollection<PoItem> PoItemSoftwareLicenseCategories { get; set; }
        public virtual ICollection<Po> Pos { get; set; }
        public virtual ICollection<Problem> Problems { get; set; }
        public virtual ICollection<Product> ProductAssetCategories { get; set; }
        public virtual ICollection<Product> ProductCategories { get; set; }
        public virtual ICollection<Product> ProductComputerCategories { get; set; }
        public virtual ICollection<Product> ProductConsumableCategories { get; set; }
        public virtual ICollection<Product> ProductHardwareCategories { get; set; }
        public virtual ICollection<Product> ProductSoftwareLicenseCategories { get; set; }
        public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<Sla> Slas { get; set; }
        public virtual ICollection<SoftwareLicense> SoftwareLicenses { get; set; }
        public virtual ICollection<StockRule> StockRules { get; set; }
        public virtual ICollection<TrackedSoftware> TrackedSoftwares { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
