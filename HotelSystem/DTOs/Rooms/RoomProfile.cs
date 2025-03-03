using AutoMapper;
using HotelSystem.DTOs.Rooms;
using HotelSystem.Models;
using HotelSystem.ViewModels.Rooms;

namespace ExaminantionSystem_R3.DTOs.Questions
{
	public class RoomProfile : Profile
	{
		public RoomProfile()
		{
			CreateMap<Room, RoomDto>()
				.ForMember(dst => dst.Facilities, opt => opt.MapFrom(src => src.RoomFacilities.Select(Facility => new RoomFacilityDto { Id = Facility.FacilityId, Name = Facility.Facility.Name })))
				.ForMember(dst => dst.Pictures, opt => opt.MapFrom(src => src.RoomPictures.Select(Picture => Picture.PictureURL)))
				.ReverseMap();

			CreateMap<CreateRoomDto, Room>()
			  .ForMember(dst => dst.RoomPictures, opt => opt.Ignore())
			  .ForMember(dst => dst.RoomFacilities, opt => opt.MapFrom(src => src.FacilityIds.Select(facilityId => new RoomFacility { FacilityId = facilityId })));
			CreateMap<CreateRoomDto, CreateRoomViewModel>().ReverseMap();
			CreateMap<EditRoomDto, EditRoomViewModel>().ReverseMap();

		}
	}
}

