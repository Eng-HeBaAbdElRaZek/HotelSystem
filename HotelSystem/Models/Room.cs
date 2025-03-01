namespace HotelSystem.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }

        public decimal Description { get; set; }

        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }                   //متاحه او لا

        public int RoomTypeId { get; set; } 
        public RoomType RoomType { get; set; } 
        public ICollection<RoomFacility> RoomFacilities { get; set; } 




        //public int Id { get; set; }
        //public Type Type { get; set; }
        //public int Price { get; set; }
        //public string Picture { get; set; }

        //public int StaffId { get; set; }
        //public Staff Staff { get; set; }
        //public IList<Facilitie> Facilities { get; set; }
        //public IList<RoomOffer> RoomOffers { get; set; }

    }
}
