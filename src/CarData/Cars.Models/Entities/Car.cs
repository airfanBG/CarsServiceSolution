using Cars.Models.BaseModels;

namespace Cars.Models.Entities
{
    public class Car : BaseModel
    {
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
    }
}
