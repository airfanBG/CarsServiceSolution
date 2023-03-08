using Cars.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Database
{
    public class ApplicationDbContext:IdentityDbContext<User>
    {
        //https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration/
        //https://learn.microsoft.com/en-us/ef/core/modeling/entity-types?tabs=data-annotations
        //https://learn.microsoft.com/en-us/ef/core/testing/
        //https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
        //https://learn.microsoft.com/en-us/ef/core/change-tracking/
        //https://learn.microsoft.com/en-us/ef/core/saving/cascade-delete
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarScheduler> CarSchedulers { get; set; }
        public DbSet<CarProblems> CarProblems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.;Database=CarService;Trusted_Connection=True;TrustServerCertificate=yes;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //https://learn.microsoft.com/en-us/ef/core/modeling/data-seeding

            var CarScheduler10 = new CarScheduler() { VisitAt = new DateTime(2023, 3, 10) };
           var CarScheduler11 = new CarScheduler() { VisitAt = new DateTime(2023, 3, 10) };
           var CarScheduler9 = new CarScheduler() { VisitAt = new DateTime(2023, 3, 10) };
           var CarScheduler12 = new CarScheduler() { VisitAt = new DateTime(2023, 3, 10) };
            modelBuilder.Entity<CarScheduler>().HasData(CarScheduler10, CarScheduler11, CarScheduler12, CarScheduler9);

            var cars = new List<Car>() {
                new Car() { CarBrand = "BMW", CarModel="314",CarShedulerId=CarScheduler10.Id } ,
                new Car() { CarBrand = "Audi",CarModel="A6",CarShedulerId=CarScheduler10.Id  } ,
                new Car() { CarBrand = "Mercedes",CarModel="s220",CarShedulerId=CarScheduler11.Id  } ,
                new Car() { CarBrand = "Ford", CarModel="Focus",CarShedulerId=CarScheduler9.Id } ,
                new Car() { CarBrand = "Peugeot",CarModel="205",CarShedulerId=CarScheduler12.Id } };
            modelBuilder.Entity<Car>().HasData(cars);

            var carProblems = new List<CarProblems>()
            {
                new CarProblems()
                {
                    CarId=cars[0].Id,
                    Description="Change the clutch",
                    CarPart="Clutch",
                    TotalAmount=1000
                },
                 new CarProblems()
                {
                    CarId=cars[0].Id,
                    Description="Breaks cylinders",
                    CarPart="breaks",
                    TotalAmount=250
                }
                 ,
                 new CarProblems()
                {
                    CarId=cars[1].Id,
                    Description="FIlters and oils",
                    CarPart="Engine",
                    TotalAmount=350
                },
                 
                 new CarProblems()
                {
                    CarId=cars[2].Id,
                    Description="Timing belt change",
                    CarPart="engine",
                    TotalAmount=1300
                }
                 ,
                 new CarProblems()
                {
                    CarId=cars[3].Id,
                    Description="Shocking absorbers",
                    CarPart="wheels",
                    TotalAmount=600
                },
                 new CarProblems()
                {
                    CarId=cars[4].Id,
                    Description="Gear bearing",
                    CarPart="transmission",
                    TotalAmount=900
                }
            };
            modelBuilder.Entity<CarProblems>().HasData(carProblems);

            base.OnModelCreating(modelBuilder);
        }
    }
}
