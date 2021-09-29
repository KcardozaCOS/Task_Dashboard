using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ImportContactsLog
    {
        public Guid Id { get; set; }
        public Guid? JobId { get; set; }
        public DateTime RunDate { get; set; }
        public string Comments { get; set; }
        public int? Duration { get; set; }
        public int? TotalUsers { get; set; }
        public int? CreatedPersons { get; set; }
        public int? CreatedAccounts { get; set; }
        public int? CreatedLocations { get; set; }
        public int? CreatedOrganizations { get; set; }
        public int? UpdatedPersons { get; set; }
        public int? Errors { get; set; }
        public DateTime UploadDate { get; set; }
        public string JobName { get; set; }
    }
}
