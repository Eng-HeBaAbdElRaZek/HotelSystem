using HotelSystem.Models;

namespace HotelSystem.Dto.Rooms
{
    public class RoomReservationDto
    {
        public int Id { get; set; }
        public DateTime CheckOn { get; set; }
        public DateTime CheckOut { get; set; }
        public bool Canceled { get; set; }
        public int RoomId { get; set; }
        public int CustomerId { get; set; }
    }
}
