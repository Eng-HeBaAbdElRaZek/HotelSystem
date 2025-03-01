namespace HotelSystem.Models
{
    public class RoomType
    {

        public int Id { get; set; } 
        public string Name { get; set; } // نوع الغرفه زوجي ولا فردي 
        public ICollection<Room> Rooms { get; set; }     //one to many 
    }

}
}
