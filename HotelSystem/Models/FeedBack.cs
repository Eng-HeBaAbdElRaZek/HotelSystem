namespace HotelSystem.Models
{
    public class FeedBack
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
