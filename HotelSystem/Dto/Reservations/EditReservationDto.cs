namespace HotelSystem.Dto.Reservations
{
    public class EditReservationDto
    {
        public int Id { get; set; }
        public DateTime CheckOn { get; set; }
        public DateTime CheckOut { get; set; }
        public int RoomId { get; set; }
    }
}
