using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SecOrganizationalUnit
    {
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
    }
}
