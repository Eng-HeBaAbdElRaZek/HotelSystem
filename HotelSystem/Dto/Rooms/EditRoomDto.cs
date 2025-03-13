using HotelSystem.Models.Enum;

namespace HotelSystem.Dto.Rooms
{
    public class EditRoomDto
    {
        public int Id { get; set; }
        public RoomType Type { get; set; }
        public int PricePerNight { get; set; }
        public int StaffId { get; set; }

    }
}
