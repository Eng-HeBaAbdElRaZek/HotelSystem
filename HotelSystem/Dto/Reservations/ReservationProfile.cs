using AutoMapper;
using HotelSystem.Models;

namespace HotelSystem.Dto.Reservations
{
    public class ReservationProfile : Profile
    {
        public ReservationProfile()
        {
            CreateMap<Reservation, CreateReservationDto>().ReverseMap();

            CreateMap<Reservation, EditReservationDto>();

        }
    }
}
