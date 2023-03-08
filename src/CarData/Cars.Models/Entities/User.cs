

using Microsoft.AspNetCore.Identity;

namespace Cars.Models.Entities
{
    public class User :IdentityUser
    {
        public User()
        {
            Id=Guid.NewGuid().ToString();
        }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
