namespace HotelSystem.Models
{
	public class FeedBack : BaseModel
	{
		public string Review { get; set; }
		public string StuffResponse { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
		public int RoomId { get; set; }
		public Room Room { get; set; }
	}
}
