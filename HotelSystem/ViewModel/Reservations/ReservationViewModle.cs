namespace HotelSystem.ViewModel.Reservations
{
    public class ReservationViewModle
    {
        public int Id { get; set; }
        public DateTime CheckOn { get; set; }
        public DateTime CheckOut { get; set; }

        public int CustomerId { get; set; }
        public int RoomId { get; set; }
    }
}
