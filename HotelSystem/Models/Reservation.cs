namespace HotelSystem.Models
{
	public class Reservation : BaseModel
	{
		public DateTime CheckOn { get; set; }
		public DateTime CheckOut { get; set; }
		public int RoomId { get; set; }
		public Room Room { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
		public bool Cancelled { get; set; }

	}
}
