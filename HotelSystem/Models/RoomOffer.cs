using HotelSystem.Models;

namespace HotelSystem.Models
{
    public class RoomOffer : BaseModel
    {
        public int RoomId { get; set; }
        public int OfferId { get; set; }
        public Room Room { get; set; }
        public Offer Offer { get; set; }

    }
}
