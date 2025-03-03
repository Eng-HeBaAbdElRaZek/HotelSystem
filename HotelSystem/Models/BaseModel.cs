namespace HotelSystem.Models
{
	public class BaseModel
	{
		public int Id { get; set; }
		public bool IsDeleted { get; set; } = false;
		public DateTime? UpdatedAt { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.Now;
	}
}
