using HotelSystem.Models;

namespace HotelSystem.Models
{
    public class Offer: BaseModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Discount { get; set; }

        public IList<RoomOffer> RoomOffers { get; set; }


    }
}
