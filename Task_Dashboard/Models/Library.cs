using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Library
    {
        public Library()
        {
            LibraryHistories = new HashSet<LibraryHistory>();
            LibraryItemOrganizations = new HashSet<LibraryItemOrganization>();
            Reservations = new HashSet<Reservation>();
        }

        public Guid Id { get; set; }
        public Guid? AssetId { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public Guid? CheckedOutToId { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public string Name { get; set; }
        public Guid? StatusId { get; set; }
        public Guid? TypeId { get; set; }
        public string Oid { get; set; }
        public string Notes { get; set; }
        public bool SharedWithEveryone { get; set; }
        public Guid? OwnerId { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual Person CheckedOutTo { get; set; }
        public virtual Person Owner { get; set; }
        public virtual Status Status { get; set; }
        public virtual ObjectType Type { get; set; }
        public virtual ICollection<LibraryHistory> LibraryHistories { get; set; }
        public virtual ICollection<LibraryItemOrganization> LibraryItemOrganizations { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
