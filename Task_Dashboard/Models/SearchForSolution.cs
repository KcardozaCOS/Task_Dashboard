using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SearchForSolution
    {
        public Guid Id { get; set; }
        public Guid ClassId { get; set; }
        public string Class { get; set; }
        public string ObjectName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Title { get; set; }
    }
}
