﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgReportCategoryLevel
    {
        public Guid ChildId { get; set; }
        public int? Level { get; set; }
    }
}
