
using HotelSystem.DTOs.Rooms;
using HotelSystem.Helpers;
using HotelSystem.Models.Enums;
using HotelSystem.Services;
using HotelSystem.ViewModels;
using HotelSystem.ViewModels.Rooms;
using Microsoft.AspNetCore.Mvc;

namespace HotelSystem.Controllers
{

	[Route("api/[controller]")]
	[ApiController]
	public class RoomController : ControllerBase
	{
		RoomService _roomService;
		public RoomController()
		{
			_roomService = new RoomService();
		}

		[HttpPost]
		public async Task<ResponseViewModel<string>> CreateRoom(CreateRoomViewModel roomVm)
		{
			try
			{
				var room = roomVm.Map<CreateRoomDto>();
				_roomService.Add(room);
				return new SuccessResponseViewModel<string>(null);
			}
			catch
			{
				return new FailureResponseViewModel<string>(ErrorCode.GeneralBadRequest);
			}
		}


		[HttpGet]
		public async Task<ResponseViewModel<IEnumerable<RoomDto>>> GetAllRooms()
		{
			var data = _roomService.GetAll();
			return ResponseViewModel<IEnumerable<RoomDto>>.Success(data);

		}


		//Delete

		[HttpDelete]
		public async Task<ResponseViewModel<string>> DeleteRoom(int id)
		{
			try
			{
				_roomService.DeleteRoom(id);
				return new SuccessResponseViewModel<string>(null);
			}
			catch
			{
				return new FailureResponseViewModel<string>(ErrorCode.GeneralBadRequest);
			}
		}


		[HttpPut]
		public async Task<ResponseViewModel<string>> UpdateRoom(EditRoomViewModel roomVm)
		{
			try
			{
				var room = roomVm.Map<EditRoomDto>();
				_roomService.Update(room);
				return new SuccessResponseViewModel<string>(null);
			}
			catch
			{
				return new FailureResponseViewModel<string>(ErrorCode.GeneralBadRequest);
			}
		}

	}
}
