using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Person
    {
        public Person()
        {
            Announcements = new HashSet<Announcement>();
            ApprovalRequests = new HashSet<ApprovalRequest>();
            ApprovalStages = new HashSet<ApprovalStage>();
            Assets = new HashSet<Asset>();
            CfgCalendarObjects = new HashSet<CfgCalendarObject>();
            CfgDashboards = new HashSet<CfgDashboard>();
            CfgDisabledViews = new HashSet<CfgDisabledView>();
            CfgLcrecurrentObjects = new HashSet<CfgLcrecurrentObject>();
            CfgSettings = new HashSet<CfgSetting>();
            CfgSnippetCategories = new HashSet<CfgSnippetCategory>();
            CfgSnippets = new HashSet<CfgSnippet>();
            CfgSystemLogNotifications = new HashSet<CfgSystemLogNotification>();
            CfgViews = new HashSet<CfgView>();
            ChangeRequestApprovals = new HashSet<ChangeRequestApproval>();
            ChangeRequestAssignees = new HashSet<ChangeRequest>();
            ChangeRequestRequesters = new HashSet<ChangeRequest>();
            Computers = new HashSet<Computer>();
            Configurations = new HashSet<Configuration>();
            Consumables = new HashSet<Consumable>();
            DocumentAuthors = new HashSet<Document>();
            DocumentOwners = new HashSet<Document>();
            GroupMembers = new HashSet<GroupMember>();
            Hardwares = new HashSet<Hardware>();
            IncidentAssignees = new HashSet<Incident>();
            IncidentRequesters = new HashSet<Incident>();
            InverseManager = new HashSet<Person>();
            KbArticleApprovedBies = new HashSet<KbArticle>();
            KbArticleAuthors = new HashSet<KbArticle>();
            KbArticleOwners = new HashSet<KbArticle>();
            LibraryCheckedOutTos = new HashSet<Library>();
            LibraryHistories = new HashSet<LibraryHistory>();
            LibraryOwners = new HashSet<Library>();
            Locations = new HashSet<Location>();
            Networks = new HashSet<Network>();
            ObjectFlags = new HashSet<ObjectFlag>();
            OrganizationalUnits = new HashSet<OrganizationalUnit>();
            PersonEmails = new HashSet<PersonEmail>();
            PersonLogins = new HashSet<PersonLogin>();
            PoAuthorizedBies = new HashSet<Po>();
            PoOwners = new HashSet<Po>();
            PoRequesters = new HashSet<Po>();
            ProblemAssignees = new HashSet<Problem>();
            ProblemRequesters = new HashSet<Problem>();
            ProjectManagers = new HashSet<Project>();
            ProjectUdfProjectContactNavigations = new HashSet<Project>();
            ProjectUdfProjectSponsorNavigations = new HashSet<Project>();
            ProjectUdfRequesterNavigations = new HashSet<Project>();
            Reservations = new HashSet<Reservation>();
            ServiceRequestAssignees = new HashSet<ServiceRequest>();
            ServiceRequestRequesters = new HashSet<ServiceRequest>();
            Services = new HashSet<Service>();
            SoftwareLicenses = new HashSet<SoftwareLicense>();
            SolutionRatings = new HashSet<SolutionRating>();
            StockRooms = new HashSet<StockRoom>();
            TrackedSoftwares = new HashSet<TrackedSoftware>();
            UserAccounts = new HashSet<UserAccount>();
            UserGroups = new HashSet<UserGroup>();
            Vendors = new HashSet<Vendor>();
            WorkCalendars = new HashSet<WorkCalendar>();
            WorkOrderAssignees = new HashSet<WorkOrder>();
            WorkOrderRequesters = new HashSet<WorkOrder>();
        }

        public Guid Id { get; set; }
        public Guid? OrganizationId { get; set; }
        public Guid? LocationId { get; set; }
        public Guid? CalendarId { get; set; }
        public bool Technician { get; set; }
        public string Address { get; set; }
        public string ImAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string Notes { get; set; }
        public string BusinessPhone { get; set; }
        public string Fax { get; set; }
        public string JobTitle { get; set; }
        public string Title { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string MiddleName { get; set; }
        public decimal? HourlyRate { get; set; }
        public string SkillLevel { get; set; }
        public string SmsEmail { get; set; }
        public string Pager { get; set; }
        public Guid? ManagerId { get; set; }
        public bool Service { get; set; }
        public string Udf0002 { get; set; }
        public string Udf0003 { get; set; }
        public bool Udf0005 { get; set; }
        public DateTime? Udf0006 { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? StatusId { get; set; }
        public Guid? GenderId { get; set; }
        public DateTime? Birthday { get; set; }
        public string FullName { get; set; }
        public string Oid { get; set; }
        public string PrimaryEmail { get; set; }
        public string PrimaryLogin { get; set; }
        public byte[] Picture { get; set; }
        public string UdfDistinguishedName { get; set; }
        public string AdimportId { get; set; }
        public DateTime? UdfVehicleYear { get; set; }
        public string UdfVehicleMake { get; set; }
        public string UdfVehicleColor { get; set; }
        public string UdfVehicleModel { get; set; }
        public string UdfPrimaryGroup { get; set; }
        public string UdfLunchPeriod { get; set; }
        public string UdfBadgeNumber { get; set; }
        public string UdfEmployeeNumber { get; set; }

        public virtual WorkCalendar Calendar { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Location Location { get; set; }
        public virtual Person Manager { get; set; }
        public virtual OrganizationalUnit Organization { get; set; }
        public virtual Status Status { get; set; }
        public virtual ObjectType Type { get; set; }
        public virtual ICollection<Announcement> Announcements { get; set; }
        public virtual ICollection<ApprovalRequest> ApprovalRequests { get; set; }
        public virtual ICollection<ApprovalStage> ApprovalStages { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
        public virtual ICollection<CfgCalendarObject> CfgCalendarObjects { get; set; }
        public virtual ICollection<CfgDashboard> CfgDashboards { get; set; }
        public virtual ICollection<CfgDisabledView> CfgDisabledViews { get; set; }
        public virtual ICollection<CfgLcrecurrentObject> CfgLcrecurrentObjects { get; set; }
        public virtual ICollection<CfgSetting> CfgSettings { get; set; }
        public virtual ICollection<CfgSnippetCategory> CfgSnippetCategories { get; set; }
        public virtual ICollection<CfgSnippet> CfgSnippets { get; set; }
        public virtual ICollection<CfgSystemLogNotification> CfgSystemLogNotifications { get; set; }
        public virtual ICollection<CfgView> CfgViews { get; set; }
        public virtual ICollection<ChangeRequestApproval> ChangeRequestApprovals { get; set; }
        public virtual ICollection<ChangeRequest> ChangeRequestAssignees { get; set; }
        public virtual ICollection<ChangeRequest> ChangeRequestRequesters { get; set; }
        public virtual ICollection<Computer> Computers { get; set; }
        public virtual ICollection<Configuration> Configurations { get; set; }
        public virtual ICollection<Consumable> Consumables { get; set; }
        public virtual ICollection<Document> DocumentAuthors { get; set; }
        public virtual ICollection<Document> DocumentOwners { get; set; }
        public virtual ICollection<GroupMember> GroupMembers { get; set; }
        public virtual ICollection<Hardware> Hardwares { get; set; }
        public virtual ICollection<Incident> IncidentAssignees { get; set; }
        public virtual ICollection<Incident> IncidentRequesters { get; set; }
        public virtual ICollection<Person> InverseManager { get; set; }
        public virtual ICollection<KbArticle> KbArticleApprovedBies { get; set; }
        public virtual ICollection<KbArticle> KbArticleAuthors { get; set; }
        public virtual ICollection<KbArticle> KbArticleOwners { get; set; }
        public virtual ICollection<Library> LibraryCheckedOutTos { get; set; }
        public virtual ICollection<LibraryHistory> LibraryHistories { get; set; }
        public virtual ICollection<Library> LibraryOwners { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<Network> Networks { get; set; }
        public virtual ICollection<ObjectFlag> ObjectFlags { get; set; }
        public virtual ICollection<OrganizationalUnit> OrganizationalUnits { get; set; }
        public virtual ICollection<PersonEmail> PersonEmails { get; set; }
        public virtual ICollection<PersonLogin> PersonLogins { get; set; }
        public virtual ICollection<Po> PoAuthorizedBies { get; set; }
        public virtual ICollection<Po> PoOwners { get; set; }
        public virtual ICollection<Po> PoRequesters { get; set; }
        public virtual ICollection<Problem> ProblemAssignees { get; set; }
        public virtual ICollection<Problem> ProblemRequesters { get; set; }
        public virtual ICollection<Project> ProjectManagers { get; set; }
        public virtual ICollection<Project> ProjectUdfProjectContactNavigations { get; set; }
        public virtual ICollection<Project> ProjectUdfProjectSponsorNavigations { get; set; }
        public virtual ICollection<Project> ProjectUdfRequesterNavigations { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<ServiceRequest> ServiceRequestAssignees { get; set; }
        public virtual ICollection<ServiceRequest> ServiceRequestRequesters { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<SoftwareLicense> SoftwareLicenses { get; set; }
        public virtual ICollection<SolutionRating> SolutionRatings { get; set; }
        public virtual ICollection<StockRoom> StockRooms { get; set; }
        public virtual ICollection<TrackedSoftware> TrackedSoftwares { get; set; }
        public virtual ICollection<UserAccount> UserAccounts { get; set; }
        public virtual ICollection<UserGroup> UserGroups { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
        public virtual ICollection<WorkCalendar> WorkCalendars { get; set; }
        public virtual ICollection<WorkOrder> WorkOrderAssignees { get; set; }
        public virtual ICollection<WorkOrder> WorkOrderRequesters { get; set; }
    }
}
