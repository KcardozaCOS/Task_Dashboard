using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class LoggedPersonViewList
    {
        public Guid Id { get; set; }
        public Guid? PersonId { get; set; }
        public string ObjectName { get; set; }
        public string Name { get; set; }
        public string View { get; set; }
        public bool Shared { get; set; }
        public bool IsAdmin { get; set; }
    }
}
