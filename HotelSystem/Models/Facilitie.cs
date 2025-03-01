namespace HotelSystem.Models
{
    public class Facility
    {
        public int Id { get; set; }
        public string Name { get; set; }     //تكيف ويفاي

        public ICollection<RoomFacility> RoomFacilities { get; set; } 
        
        //public int RoomId { get; set; }
        //public Room Room { get; set; }
    }
}
