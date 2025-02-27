namespace HotelSystem.Data
{
    public class Reservation
    {
        public int Id { get; set; }

        public DateTime CheckOn  { get; set; }
        public DateTime CheckOut { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
