using Front_To_Back_practice.DAL;
using Front_To_Back_practice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_To_Back_practice.Controllers
{
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;
        public TeamController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Team> teams = _context.Teams.Include(p=>p.Position).ToList();

            return View(teams);
        }
    }
}
