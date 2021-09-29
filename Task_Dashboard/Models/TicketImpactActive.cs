﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class TicketImpactActive
    {
        public Guid Id { get; set; }
        public string Impact { get; set; }
        public bool Default { get; set; }
        public bool System { get; set; }
        public int? Rank { get; set; }
        public bool Active { get; set; }
        public string Tags { get; set; }
        public Guid? ClassId { get; set; }
    }
}
