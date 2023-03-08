using Cars.Models.BaseModels;

namespace Cars.Models.Entities
{
    public class Car : BaseModel
    {
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string? CarShedulerId { get; set; }
        public CarScheduler CarScheduler { get; set; }
        public List<CarProblems> CarProblems { get; set; }
    }
}
