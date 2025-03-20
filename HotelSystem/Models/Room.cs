using HotelSystem.Models;
using HotelSystem.Models.Enum;

namespace HotelSystem.Models
{
    public class Room : BaseModel
    {
        public RoomType Type { get; set; }
        public int PricePerNight { get; set; }
        public bool IsAvalible { get; set; }

        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        public IList<RoomImage> Images { get; set; }
        public IList<RoomFacilitie> Facilities { get; set; }
        public IList<RoomOffer> RoomOffers { get; set; }
        public IList<Reservation> Reservations { get; set; }

    }
}
