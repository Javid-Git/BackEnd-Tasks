using Front_To_Back_practice.DAL;
using Front_To_Back_practice.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_To_Back_practice.Controllers
{
    public class ServicesController : Controller
    {
        private readonly AppDbContext _context;

        public ServicesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Service> services = _context.Services.ToList();
            return View(services);
        }
    }
}
