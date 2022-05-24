using FrontToBack_Task.DAL;
using FrontToBack_Task.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack_Task.Controllers
{
    public class TrainersController : Controller
    {
        private readonly AppDbContext _context;

        public TrainersController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Trainers> trainers = _context.Trainers.ToList();
            return View(trainers);
        }
    }
}
