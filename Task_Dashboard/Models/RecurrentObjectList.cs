using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class RecurrentObjectList
    {
        public Guid Id { get; set; }
        public int JobType { get; set; }
        public string JobName { get; set; }
        public bool Enabled { get; set; }
        public DateTime? NextRunDate { get; set; }
        public DateTime? LastRunDate { get; set; }
        public string LastRunStatus { get; set; }
        public string Schedule { get; set; }
        public string JobDescription { get; set; }
        public bool Expired { get; set; }
        public Guid LceventId { get; set; }
        public int Cid { get; set; }
        public string Action { get; set; }
        public Guid ClassId { get; set; }
        public string Object { get; set; }
        public string CreatedBy { get; set; }
    }
}
