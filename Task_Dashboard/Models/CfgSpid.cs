using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgSpid
    {
        public int Spid { get; set; }
        public DateTime? OperationDate { get; set; }
        public string Author { get; set; }
        public Guid? AuthorId { get; set; }
        public string Action { get; set; }
        public Guid Id { get; set; }
        public string WfItem { get; set; }
        public string Fields { get; set; }
    }
}
