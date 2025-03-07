using Microsoft.AspNetCore.Identity;

namespace HotelSystem.Models
{
    public class UserModel :IdentityUser
    {
        public bool Deleted { get; set; }


    }
}
