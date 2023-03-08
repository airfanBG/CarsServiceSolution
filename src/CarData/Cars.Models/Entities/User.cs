

using Microsoft.AspNetCore.Identity;

namespace Cars.Models.Entities
{
    public class User :IdentityUser
    {
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
