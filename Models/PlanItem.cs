using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_To_Back_practice.Models
{
    public class PlanItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PricingPlanItem> PricingPlanItems { get; set; }

    }
}
