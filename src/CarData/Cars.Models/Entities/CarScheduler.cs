using Cars.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Models.Entities
{
    public class CarScheduler:BaseModel
    {
        public DateTime VisitAt { get; set; }
        public List<Car> Cars { get; set; }
    }
}
