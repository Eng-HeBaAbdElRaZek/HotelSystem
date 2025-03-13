using HotelSystem.Dto.Rooms;

namespace HotelSystem.ViewModel.Rooms.Facilities
{
    public class FacilitieViewModel
    {
        public string Name { get; set; }

        public IList<RoomFacilitieDto> FacilitiesDto { get; set; } // room facilities dto and profile
    }
}
