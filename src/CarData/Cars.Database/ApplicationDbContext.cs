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
            var cars = new List<Car>() {
                new Car() { CarBrand = "BMW", CarModel="314",CarScheduler=new CarScheduler(){VisitAt=new DateTime(2023,3,10) } } ,
                new Car() { CarBrand = "Audi",CarModel="A6",CarScheduler=new CarScheduler(){VisitAt=new DateTime(2023,3,10) } } ,
                new Car() { CarBrand = "Mercedes",CarModel="s220",CarScheduler=new CarScheduler(){VisitAt=new DateTime(2023,3,11) } } ,
                new Car() { CarBrand = "Ford", CarModel="Focus",CarScheduler=new CarScheduler(){VisitAt=new DateTime(2023,3,9) } } ,
                new Car() { CarBrand = "Peugeot",CarModel="205",CarScheduler=new CarScheduler(){VisitAt=new DateTime(2023,3,12) } } };
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


        }
    }
}
