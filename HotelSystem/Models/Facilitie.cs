using ExaminantionSystem_R3.Models;

namespace HotelSystem.Models
{
    public class Facilitie : BaseModel
    {
        public string Name { get; set; }

        public IList<RoomFacilitie> Facilities { get; set; }

    }
}
