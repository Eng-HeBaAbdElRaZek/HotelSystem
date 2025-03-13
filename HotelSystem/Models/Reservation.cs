using ExaminantionSystem_R3.Models;

namespace HotelSystem.Models
{
    public class Reservation: BaseModel
    {

        public DateTime CheckOn { get; set; }
        public DateTime CheckOut { get; set; }
        public bool Canceled { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
    }
}
