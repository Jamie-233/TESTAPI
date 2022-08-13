using System;
using Microsoft.EntityFrameworkCore;
using TEST.Models;

namespace TEST.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        // db set mapping to one table
        public DbSet<TouristRoute> TouristRoutes { get; set; }
        public DbSet<TouristRoutePircture> TouristRoutePirctures { get; set; }
    }
}

