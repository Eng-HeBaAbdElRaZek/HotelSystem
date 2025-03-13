using HotelSystem.Dto.Rooms;
using HotelSystem.Models;
using HotelSystem.Models.Enum;

namespace HotelSystem.ViewModel.Rooms
{
    public class RoomViewModel
    {
        public RoomType Type { get; set; }
        public int PricePerNight { get; set; }

        public IList<RoomImageDto> ImagesDto { get; set; } // room images dto and profile
        public IList<RoomFacilitieDto> FacilitiesDto { get; set; } // room facilities dto and profile
        public IList<RoomOfferDto> OffersDto { get; set; } // room offers dto and profile
        public IList<RoomReservationDto> ReservationsDto { get; set; } // room reservations dto and profile
    }
}
