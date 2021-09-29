using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SecSla
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? StatusId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public Guid? ServiceId { get; set; }
        public Guid? ServiceProviderId { get; set; }
        public Guid? ServiceLevelId { get; set; }
        public string Notes { get; set; }
        public string Oid { get; set; }
        public bool Global { get; set; }
        public double? UdfExpCommit { get; set; }
        public int? UdfEstEffort { get; set; }
    }
}
