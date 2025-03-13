namespace HotelSystem.Dto.Reservations
{
    public class CreateReservationDto
    {
        public DateTime CheckOn { get; set; }
        public DateTime CheckOut { get; set; }

        public int CustomerId { get; set; }
        public int RoomId { get; set; }
    }
}
