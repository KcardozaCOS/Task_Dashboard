using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgArchivingJobOption
    {
        public Guid Id { get; set; }
        public string Server { get; set; }
        public string DataBase { get; set; }
        public bool UseServiceAccount { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Ntauth { get; set; }
        public string ObjectsData { get; set; }
        public int? Action { get; set; }
    }
}
