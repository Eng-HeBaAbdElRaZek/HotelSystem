namespace HotelSystem.Data
{
    public class RoomOffer
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int OfferId { get; set; }
        public Room Room { get; set; }  
        public Offer Offer { get; set; }

    }
}
