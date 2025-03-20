using HotelSystem.Models.Enum;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HotelSystem.Models
{
    public class Customer : UserModel
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public IList<Reservation> Reservation { get; set; }

        public IList<FeedBack> FeedBacks { get; set; }
    }
}
