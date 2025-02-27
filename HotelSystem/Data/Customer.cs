namespace HotelSystem.Data
{
    public class Customer :UserModel
    {
        public string Name { get; set; }    
        public string Email { get; set; }   
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }

        public IList<FeedBack> FeedBacks { get; set; }
    }
}
