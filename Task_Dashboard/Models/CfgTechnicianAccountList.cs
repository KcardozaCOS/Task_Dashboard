using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgTechnicianAccountList
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public bool Active { get; set; }
        public string AccountType { get; set; }
        public string Person { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Organization { get; set; }
        public string Location { get; set; }
    }
}
