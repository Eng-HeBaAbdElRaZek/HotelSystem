using HotelSystem.Models;
using HotelSystem.Models.Enum;

namespace HotelSystem.Models
{
    public class RoleFeature :BaseModel
    { 
        public Role Role { get; set; }
        public Feature Feature { get; set; }
    }
}
