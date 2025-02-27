namespace HotelSystem.Data
{
    public class Offer
    {
        public int Id { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Discount { get; set; }

        public IList<RoomOffer> RoomOffers  { get; set; }


    }
}
