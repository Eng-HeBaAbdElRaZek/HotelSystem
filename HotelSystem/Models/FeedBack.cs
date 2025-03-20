using HotelSystem.Models;

namespace HotelSystem.Models
{
    public class FeedBack : BaseModel
    {
        public string Text { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
