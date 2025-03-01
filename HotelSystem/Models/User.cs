namespace HotelSystem.Models
{
	public class User : BaseModel
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public ICollection<UserRole> UserRoles { get; set; }
		public ICollection<Reservation> Reservations { get; set; }

	}
}
