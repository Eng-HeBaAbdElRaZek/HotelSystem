using ExaminantionSystem_R3.Models;

namespace HotelSystem.Models
{
    public class Reservation: BaseModel
    {

        public DateTime CheckOn { get; set; }
        public DateTime CheckOut { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
