using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SecLibrary
    {
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
    }
}
