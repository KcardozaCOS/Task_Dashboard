using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class BrandList
    {
        public Guid Id { get; set; }
        public Guid? OrganizationId { get; set; }
        public string Brand { get; set; }
        public string WebPage { get; set; }
        public bool Active { get; set; }
        public string Organization { get; set; }
    }
}
