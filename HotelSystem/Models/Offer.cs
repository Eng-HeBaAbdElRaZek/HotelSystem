namespace HotelSystem.Models
{
	public class Offer : BaseModel
	{

		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public int DiscountPercentage { get; set; }
		public ICollection<RoomOffer> RoomOffers { get; set; }


	}
}
