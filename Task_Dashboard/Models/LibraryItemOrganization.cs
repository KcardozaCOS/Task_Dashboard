using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class LibraryItemOrganization
    {
        public Guid Id { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid LibraryItemId { get; set; }

        public virtual Library LibraryItem { get; set; }
        public virtual OrganizationalUnit Organization { get; set; }
    }
}
