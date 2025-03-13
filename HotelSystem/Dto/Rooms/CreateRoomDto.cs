using HotelSystem.Models.Enum;
using HotelSystem.Models;

namespace HotelSystem.Dto.Rooms
{
    public class CreateRoomDto
    {
        public RoomType Type { get; set; }
        public int PricePerNight { get; set; }
        public int StaffId { get; set; }

    }
}
