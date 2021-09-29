﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Configuration
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

        public virtual ObjectIndex AssociatedCi { get; set; }
        public virtual ObjectCategory Category { get; set; }
        public virtual Location Location { get; set; }
        public virtual OrganizationalUnit Organization { get; set; }
        public virtual Person Owner { get; set; }
        public virtual Status Status { get; set; }
        public virtual ObjectType Type { get; set; }
    }
}
