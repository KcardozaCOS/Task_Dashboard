﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLctemplateList
    {
        public Guid Id { get; set; }
        public Guid WfobjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? UsageCount { get; set; }
    }
}
