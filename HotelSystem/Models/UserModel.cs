using HotelSystem.Models.Enum;
using Microsoft.AspNetCore.Identity;

namespace HotelSystem.Models
{
    public class UserModel :IdentityUser
    {
        public bool Deleted { get; set; }
        public Role Role { get; set; }


    }
}
