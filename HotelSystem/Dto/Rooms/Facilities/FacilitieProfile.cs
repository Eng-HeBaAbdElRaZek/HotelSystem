using AutoMapper;
using HotelSystem.Models;

namespace HotelSystem.Dto.Rooms.Facilities
{
    public class FacilitieProfile : Profile
    {
        public FacilitieProfile()
        {
            CreateMap<Facilitie, CreateFaciliteDto>().ReverseMap();
            CreateMap<Facilitie, EditeFaciliteDto>().ReverseMap();
        }
    }
}
