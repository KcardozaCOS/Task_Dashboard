using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SecConfiguration
    {
        public Guid Id { get; set; }
        public string Oid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? StatusId { get; set; }
        public Guid? OwnerId { get; set; }
        public Guid? OrganizationId { get; set; }
        public Guid? LocationId { get; set; }
        public Guid? AssociatedCiId { get; set; }
        public string Notes { get; set; }
        public string UdfSupportGroup { get; set; }
        public string UdfShortName { get; set; }
        public string UdfXmlData { get; set; }
    }
}
