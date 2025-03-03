using HotelSystem.Models.Enums;

namespace HotelSystem.Models
{
	public class Room : BaseModel
	{
		public string Name { get; set; }
		public RoomType Type { get; set; }
		public decimal PricePerNight { get; set; }
		public ICollection<RoomPicture> RoomPictures { get; set; }
		public ICollection<RoomFacility> RoomFacilities { get; set; }
		public ICollection<RoomOffer> RoomOffers { get; set; }
		public ICollection<Reservation> Reservations { get; set; }
	}
}
