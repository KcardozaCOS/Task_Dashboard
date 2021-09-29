using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SecReservation
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
    }
}
