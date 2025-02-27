namespace HotelSystem.Models
{
    public class Room
    {
        public int Id { get; set; }
        public Type Type { get; set; }
        public int Price { get; set; }
        public string Picture { get; set; }

        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        public IList<Facilitie> Facilities { get; set; }
        public IList<RoomOffer> RoomOffers { get; set; }

    }
}
