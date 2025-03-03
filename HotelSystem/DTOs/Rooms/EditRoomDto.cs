using HotelSystem.Models.Enums;

namespace HotelSystem.DTOs.Rooms
{
	public class EditRoomDto
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public RoomType Type { get; set; }
		public decimal PricePerNight { get; set; }
		public List<IFormFile>? Pictures { get; set; }
		public List<int>? FacilityIds { get; set; }
	}
}
