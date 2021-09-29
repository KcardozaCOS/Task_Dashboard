using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class AddressShipping
    {
        public Guid Id { get; set; }
        public string Contact { get; set; }
        public bool Billing { get; set; }
        public bool Shipping { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Phone { get; set; }
        public string WebPage { get; set; }
    }
}
