using Cars.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Models.Entities
{
    public class CarProblems:BaseModel
    {
        public string Description { get; set; }
        public string CarPart { get; set; }
        public decimal TotalAmount { get; set; }
        public string CarId { get; set; }
        public Car Car { get; set; }
    }
}
