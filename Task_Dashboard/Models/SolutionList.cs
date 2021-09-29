using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SolutionList
    {
        public Guid Id { get; set; }
        public int ClassIndex { get; set; }
        public string Class { get; set; }
        public string Oid { get; set; }
        public Guid ClassId { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid? StatusId { get; set; }
        public Guid? TypeId { get; set; }
    }
}
