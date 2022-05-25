using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_To_Back_practice.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsFeatured { get; set; }
        public List<PricingPlanItem> PricingPlanItems { get; set; }

    }
}
