using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Reservation
    {
        public Guid Id { get; set; }
        public string Oid { get; set; }
        public Guid LibraryItemId { get; set; }
        public Guid RequesterId { get; set; }
        public Guid? StatusId { get; set; }
        public DateTime? ReservationDateFrom { get; set; }
        public DateTime? ReservationDateTo { get; set; }
        public Guid? TypeId { get; set; }
        public string Notes { get; set; }

        public virtual Library LibraryItem { get; set; }
        public virtual Person Requester { get; set; }
        public virtual Status Status { get; set; }
        public virtual ObjectType Type { get; set; }
    }
}
