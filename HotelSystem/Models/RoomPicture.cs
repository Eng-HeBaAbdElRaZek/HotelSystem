namespace HotelSystem.Models
{
	public class RoomPicture : BaseModel
	{
		public int RoomId { get; set; }
		public Room Room { get; set; }
		public string PictureURL { get; set; }

	}
}
