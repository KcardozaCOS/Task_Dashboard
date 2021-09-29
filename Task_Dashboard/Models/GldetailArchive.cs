using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class GldetailArchive
    {
        public int GldetailId { get; set; }
        public DateTime? GlinterfaceDate { get; set; }
        public int CustomerId { get; set; }
        public int TransactionId { get; set; }
        public int TransactionSplitId { get; set; }
        public int AccountNo { get; set; }
        public int CostCenter { get; set; }
        public decimal DebitAmount { get; set; }
        public decimal CreditAmount { get; set; }
    }
}
