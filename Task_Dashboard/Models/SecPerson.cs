using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SecPerson
    {
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
    }
}
