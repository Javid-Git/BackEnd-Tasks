using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack_Task.Models
{
    public class PlanItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PricingPlanItem> PricingPlanItems { get; set; }

    }
}
