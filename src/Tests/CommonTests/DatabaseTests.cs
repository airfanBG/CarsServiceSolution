using Cars.Database;
using Microsoft.EntityFrameworkCore;

namespace CommonTests
{
    public class DatabaseTests
    {
        //1. https://learn.microsoft.com/en-us/ef/core/testing/
        // 2. Mocking database with Moq https://github.com/MichalJankowskii/Moq.EntityFrameworkCore
        [Fact]
        public void Test_Database_Add_Car_InMemory_Then_Get_Result()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "CarsService")
            .Options;
            using (ApplicationDbContext db=new ApplicationDbContext(options))
            {
                db.Cars.Add(new Cars.Models.Entities.Car()
                {
                    CarBrand = "BMW",
                    CarModel = "314",

                });
                db.SaveChanges();

            }

            using (ApplicationDbContext db = new ApplicationDbContext(options))
            {
                //Act
                var getAll = db.Cars.ToList();

                //Assert
                Assert.Equal(1, getAll.Count);
            }
        }
    }
}