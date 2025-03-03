using HotelSystem.Models.Enums;

namespace HotelSystem.DTOs.Rooms
{
	public class RoomDto
	{
		public string Name { get; set; }
		public RoomType Type { get; set; }
		public decimal PricePerNight { get; set; }
		public List<string>? Pictures { get; set; }
		public List<RoomFacilityDto>? Facilities { get; set; }
	}
}
