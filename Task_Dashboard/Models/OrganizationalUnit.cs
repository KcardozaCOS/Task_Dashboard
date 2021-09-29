using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class OrganizationalUnit
    {
        public OrganizationalUnit()
        {
            Assets = new HashSet<Asset>();
            Brands = new HashSet<Brand>();
            CfgOrganizationalUnitParentChildren = new HashSet<CfgOrganizationalUnitParent>();
            CfgOrganizationalUnitParentParents = new HashSet<CfgOrganizationalUnitParent>();
            CfgSecurityRoleOus = new HashSet<CfgSecurityRoleOu>();
            ChangeRequests = new HashSet<ChangeRequest>();
            Computers = new HashSet<Computer>();
            Configurations = new HashSet<Configuration>();
            Consumables = new HashSet<Consumable>();
            ContractProviders = new HashSet<Contract>();
            ContractReceivers = new HashSet<Contract>();
            Documents = new HashSet<Document>();
            Hardwares = new HashSet<Hardware>();
            Incidents = new HashSet<Incident>();
            InverseParent = new HashSet<OrganizationalUnit>();
            KbArticleOrganizations = new HashSet<KbArticleOrganization>();
            LibraryItemOrganizations = new HashSet<LibraryItemOrganization>();
            Networks = new HashSet<Network>();
            People = new HashSet<Person>();
            Pos = new HashSet<Po>();
            Problems = new HashSet<Problem>();
            Receivers = new HashSet<Receiver>();
            ServiceRequests = new HashSet<ServiceRequest>();
            Services = new HashSet<Service>();
            Slas = new HashSet<Sla>();
            SoftwareLicenseOrganizations = new HashSet<SoftwareLicenseOrganization>();
            SoftwareLicenses = new HashSet<SoftwareLicense>();
            TrackedSoftwares = new HashSet<TrackedSoftware>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? LocationId { get; set; }
        public Guid? CategoryId { get; set; }
        public string Name { get; set; }
        public string Placement { get; set; }
        public bool Internal { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Notes { get; set; }
        public string WebPage { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Udf0001 { get; set; }
        public string Udf0002 { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? StatusId { get; set; }
        public string Oid { get; set; }
        public bool Vendor { get; set; }
        public bool Customer { get; set; }
        public Guid? ManagerId { get; set; }

        public virtual ObjectCategory Category { get; set; }
        public virtual Location Location { get; set; }
        public virtual Person Manager { get; set; }
        public virtual OrganizationalUnit Parent { get; set; }
        public virtual Status Status { get; set; }
        public virtual ObjectType Type { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
        public virtual ICollection<Brand> Brands { get; set; }
        public virtual ICollection<CfgOrganizationalUnitParent> CfgOrganizationalUnitParentChildren { get; set; }
        public virtual ICollection<CfgOrganizationalUnitParent> CfgOrganizationalUnitParentParents { get; set; }
        public virtual ICollection<CfgSecurityRoleOu> CfgSecurityRoleOus { get; set; }
        public virtual ICollection<ChangeRequest> ChangeRequests { get; set; }
        public virtual ICollection<Computer> Computers { get; set; }
        public virtual ICollection<Configuration> Configurations { get; set; }
        public virtual ICollection<Consumable> Consumables { get; set; }
        public virtual ICollection<Contract> ContractProviders { get; set; }
        public virtual ICollection<Contract> ContractReceivers { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Hardware> Hardwares { get; set; }
        public virtual ICollection<Incident> Incidents { get; set; }
        public virtual ICollection<OrganizationalUnit> InverseParent { get; set; }
        public virtual ICollection<KbArticleOrganization> KbArticleOrganizations { get; set; }
        public virtual ICollection<LibraryItemOrganization> LibraryItemOrganizations { get; set; }
        public virtual ICollection<Network> Networks { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<Po> Pos { get; set; }
        public virtual ICollection<Problem> Problems { get; set; }
        public virtual ICollection<Receiver> Receivers { get; set; }
        public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<Sla> Slas { get; set; }
        public virtual ICollection<SoftwareLicenseOrganization> SoftwareLicenseOrganizations { get; set; }
        public virtual ICollection<SoftwareLicense> SoftwareLicenses { get; set; }
        public virtual ICollection<TrackedSoftware> TrackedSoftwares { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
