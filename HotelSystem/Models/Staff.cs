namespace HotelSystem.Models
{
    public class Staff : UserModel
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public IList<Room> Rooms { get; set; }

    }
}
