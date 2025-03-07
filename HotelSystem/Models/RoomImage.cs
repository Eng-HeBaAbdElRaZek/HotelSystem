using ExaminantionSystem_R3.Models;

namespace HotelSystem.Models
{
    public class RoomImage : BaseModel
    {
        public string ImgUrl { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }

    }
}
