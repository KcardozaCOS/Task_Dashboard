using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ThresholdAction
    {
        public ThresholdAction()
        {
            StockRuleThresholdAction1s = new HashSet<StockRule>();
            StockRuleThresholdAction2s = new HashSet<StockRule>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? Rank { get; set; }
        public bool System { get; set; }
        public bool Active { get; set; }
        public string Tags { get; set; }

        public virtual ICollection<StockRule> StockRuleThresholdAction1s { get; set; }
        public virtual ICollection<StockRule> StockRuleThresholdAction2s { get; set; }
    }
}
