using Cars.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Models.BaseModels
{
    /// <summary>
    /// Main class which has base properties
    /// </summary>
    public class BaseModel : IBaseEntity
    {
        //https://learn.microsoft.com/en-us/ef/core/modeling/
        //https://learn.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key
        //https://learn.microsoft.com/en-us/ef/core/modeling/keys?tabs=data-annotations
        //https://learn.microsoft.com/en-us/ef/core/modeling/generated-properties?tabs=data-annotations
        //https://learn.microsoft.com/en-us/ef/core/modeling/shadow-properties
        public BaseModel()
        {
            Id = Guid.NewGuid().ToString();
        }
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
