using System;
using System.IO;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using TEST.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace TEST.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}

        // db set mapping to one table
        public DbSet<TouristRoute> TouristRoutes { get; set; }
        public DbSet<TouristRoutePircture> TouristRoutePirctures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<TouristRoute>().HasData(new TouristRoute()
            //{
            //    Id=Guid.NewGuid(),
            //    Title="test title",
            //    Description="description",
            //    OriginalPrice=0,
            //    CreateTime=DateTime.UtcNow,
            //});

            var  touristRouteJsonData = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Database/touristRoutesMockData.json");
            IList<TouristRoute> touristRoutes = JsonConvert.DeserializeObject<IList<TouristRoute>>(touristRouteJsonData);
            modelBuilder.Entity<TouristRoute>().HasData(touristRoutes);


            var touristRoutePictureJsonData = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Database/touristRoutePicturesMockData.json");
            IList<TouristRoutePircture> touristRoutePictures = JsonConvert.DeserializeObject<IList<TouristRoutePircture>>(touristRoutePictureJsonData);
            modelBuilder.Entity<TouristRoutePircture>().HasData(touristRoutePictures);

            base.OnModelCreating(modelBuilder);
        }
    }
}

