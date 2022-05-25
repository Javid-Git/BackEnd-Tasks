using Front_To_Back_practice.DAL;
using Front_To_Back_practice.ViewModels.PricingViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_To_Back_practice.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;

        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            PricingViewModel pricingViewModel = new PricingViewModel
            {
                Pricings = _context.Pricings.Include(p => p.PricingPlanItems).ThenInclude(pi => pi.PlanItem).ToList(),
                PlanItems = _context.PlanItems.ToList()

            };
            return View(pricingViewModel);
        }
    }
}
