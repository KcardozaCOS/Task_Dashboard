using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Title
    {
        public Guid Id { get; set; }
        public string Title1 { get; set; }
        public int? Rank { get; set; }
        public bool System { get; set; }
        public string Tags { get; set; }
    }
}
