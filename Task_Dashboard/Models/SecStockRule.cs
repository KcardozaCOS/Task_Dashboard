using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SecStockRule
    {
        public Guid Id { get; set; }
        public string Oid { get; set; }
        public string Name { get; set; }
        public Guid? ProductId { get; set; }
        public Guid? StockRoomId { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? StatusId { get; set; }
        public int? Threshold1 { get; set; }
        public Guid? ThresholdAction1Id { get; set; }
        public int? ReorderQuantity1 { get; set; }
        public int? Threshold2 { get; set; }
        public Guid? ThresholdAction2Id { get; set; }
        public int? ReorderQuantity2 { get; set; }
        public string Notes { get; set; }
    }
}
