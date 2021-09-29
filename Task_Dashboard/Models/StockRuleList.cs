using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class StockRuleList
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
        public string Product { get; set; }
        public string StockRoom { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }
        public string ThresholdAction1 { get; set; }
        public string ThresholdAction2 { get; set; }
        public int? ActualQuantity { get; set; }
        public int? FlagStatus { get; set; }
    }
}
