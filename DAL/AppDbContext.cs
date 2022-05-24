using FrontToBack_Task.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack_Task.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Courses> Courses { get; set; }
        public DbSet<Trainers> Trainers { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<PlanItem> PlanItems { get; set; }
        public DbSet<PricingPlanItem> PricingPlanItems { get; set; }
    }
}
