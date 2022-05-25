using Front_To_Back_practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_To_Back_practice.ViewModels.PricingViewModels
{
    public class PricingViewModel
    {
        public List<Pricing> Pricings { get; set; }
        public List<PlanItem> PlanItems { get; set; }
    }
}
