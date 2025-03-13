using AutoMapper;
using HotelSystem.Dto.Reservations;
using HotelSystem.Models;

namespace HotelSystem.Dto.Rooms
{
    public class RoomProfile : Profile  
    {
        public RoomProfile()
        {
            CreateMap<Room, CreateRoomDto>().ReverseMap();
            CreateMap<Room, EditRoomDto>().ReverseMap();

        }

    }
}
