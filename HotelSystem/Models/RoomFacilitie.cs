using ExaminantionSystem_R3.Models;

namespace HotelSystem.Models
{
    public class RoomFacilitie : BaseModel
    {
        public int RoomId { get; set; }
        public int FacilitieId { get; set; }
        public Room Room { get; set; }
        public Facilitie Facilitie { get; set; }

    }
}
