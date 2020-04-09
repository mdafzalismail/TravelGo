using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelGo_final.Model;

namespace TravelGo_final.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<AddTrip> addTrips { get; set; }
        public DbSet<feedBack> feedBack { get; set; }
    }
}

