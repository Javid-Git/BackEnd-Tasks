using Front_To_Back_practice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_To_Back_practice.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<PlanItem> PlanItems { get; set; }
        public DbSet<PricingPlanItem> PricingPlanItems { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
