using DonicaBiler.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonicaBiler.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarImage> CarImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .HasMany(c => c.Images)
                .WithOne(i => i.Car)
                .HasForeignKey(i => i.CarId);

            // Seed data for Car table
            modelBuilder.Entity<Car>().HasData(
                new Car { CarId = 1, Type = "Sedan", ModelName = "VW Touran TSi 150 Comfortline 7prs", Year = 2015, FirstRegistration = new DateTime(2015, 4, 20), Kilometers = 50000, FuelType = "Petrol", FuelConsumption = 15.5M, GreenOwnershipTax = 200, EngineSize = 1.8M, Acceleration = 9.2M, TopSpeed = 180, MaxTowingWeight = 1200, Price = 15000,
                    ImageUrl = "https://images.unsplash.com/photo-1563729784474-d77dbb933a9e?ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60"
                },
                new Car { CarId = 2, Type = "SUV", ModelName = "Toyota Yaris Hybrid H3 e-CVT", Year = 2017, FirstRegistration = new DateTime(2017, 8, 15), Kilometers = 30000, FuelType = "Diesel", FuelConsumption = 12.5M, GreenOwnershipTax = 250, EngineSize = 2.0M, Acceleration = 7.5M, TopSpeed = 210, MaxTowingWeight = 1500, Price = 25000,
                    ImageUrl = "https://images.unsplash.com/photo-1542362567-b07e54358753?ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60"
                },
                 new Car
                 {
                     CarId = 3,
                     Type = "SUV",
                     ModelName = "Toyota Yaris Hybrid H3 e-CVT",
                     Year = 2017,
                     FirstRegistration = new DateTime(2017, 8, 15),
                     Kilometers = 30000,
                     FuelType = "Diesel",
                     FuelConsumption = 12.5M,
                     GreenOwnershipTax = 250,
                     EngineSize = 2.0M,
                     Acceleration = 7.5M,
                     TopSpeed = 210,
                     MaxTowingWeight = 1500,
                     Price = 25000,
                     ImageUrl = "https://images.unsplash.com/photo-1542362567-b07e54358753?ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60"
                 },
                  new Car
                  {
                      CarId = 4,
                      Type = "SUV",
                      ModelName = "Toyota Yaris Hybrid H3 e-CVT",
                      Year = 2017,
                      FirstRegistration = new DateTime(2017, 8, 15),
                      Kilometers = 30000,
                      FuelType = "Diesel",
                      FuelConsumption = 12.5M,
                      GreenOwnershipTax = 250,
                      EngineSize = 2.0M,
                      Acceleration = 7.5M,
                      TopSpeed = 210,
                      MaxTowingWeight = 1500,
                      Price = 25000,
                      ImageUrl = "https://images.unsplash.com/photo-1542362567-b07e54358753?ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60"
                  },
                   new Car
                   {
                       CarId = 5,
                       Type = "SUV",
                       ModelName = "Toyota Yaris Hybrid H3 e-CVT",
                       Year = 2017,
                       FirstRegistration = new DateTime(2017, 8, 15),
                       Kilometers = 30000,
                       FuelType = "Diesel",
                       FuelConsumption = 12.5M,
                       GreenOwnershipTax = 250,
                       EngineSize = 2.0M,
                       Acceleration = 7.5M,
                       TopSpeed = 210,
                       MaxTowingWeight = 1500,
                       Price = 25000,
                       ImageUrl = "https://images.unsplash.com/photo-1542362567-b07e54358753?ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60"
                   },
                    new Car
                    {
                        CarId = 6,
                        Type = "SUV",
                        ModelName = "Toyota Yaris Hybrid H3 e-CVT",
                        Year = 2017,
                        FirstRegistration = new DateTime(2017, 8, 15),
                        Kilometers = 30000,
                        FuelType = "Diesel",
                        FuelConsumption = 12.5M,
                        GreenOwnershipTax = 250,
                        EngineSize = 2.0M,
                        Acceleration = 7.5M,
                        TopSpeed = 210,
                        MaxTowingWeight = 1500,
                        Price = 25000,
                        ImageUrl = "https://images.unsplash.com/photo-1542362567-b07e54358753?ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60"
                    },
                     new Car
                     {
                         CarId = 7,
                         Type = "SUV",
                         ModelName = "Toyota Yaris Hybrid H3 e-CVT",
                         Year = 2017,
                         FirstRegistration = new DateTime(2017, 8, 15),
                         Kilometers = 30000,
                         FuelType = "Diesel",
                         FuelConsumption = 12.5M,
                         GreenOwnershipTax = 250,
                         EngineSize = 2.0M,
                         Acceleration = 7.5M,
                         TopSpeed = 210,
                         MaxTowingWeight = 1500,
                         Price = 25000,
                         ImageUrl = "https://images.unsplash.com/photo-1542362567-b07e54358753?ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60"
                     },
                      new Car
                      {
                          CarId = 8,
                          Type = "SUV",
                          ModelName = "Toyota Yaris Hybrid H3 e-CVT",
                          Year = 2017,
                          FirstRegistration = new DateTime(2017, 8, 15),
                          Kilometers = 30000,
                          FuelType = "Diesel",
                          FuelConsumption = 12.5M,
                          GreenOwnershipTax = 250,
                          EngineSize = 2.0M,
                          Acceleration = 7.5M,
                          TopSpeed = 210,
                          MaxTowingWeight = 1500,
                          Price = 25000,
                          ImageUrl = "https://images.unsplash.com/photo-1542362567-b07e54358753?ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60"
                      }
            );

            // Optionally seed data for CarImage table linked to cars
            modelBuilder.Entity<CarImage>().HasData(
                new CarImage { CarImageId = 1, CarId = 1, ImageUrl = "https://example.com/image1.jpg" },
                new CarImage { CarImageId = 2, CarId = 1, ImageUrl = "https://example.com/image2.jpg" },
                new CarImage { CarImageId = 3, CarId = 2, ImageUrl = "https://example.com/image3.jpg" }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
