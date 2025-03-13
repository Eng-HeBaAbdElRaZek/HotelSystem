using HotelSystem.Dto.Rooms;
using HotelSystem.Helpers;
using HotelSystem.Models;
using HotelSystem.Services;
using HotelSystem.ViewModel.Rooms;
using HotelSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace HotelSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        RoomServices _roomServices;
        public RoomsController()
        {
             
            _roomServices = new RoomServices();
        }
        // GET: api/<RoomsController>
        [HttpGet]
        public async Task<ResponseViewModel<IEnumerable<RoomViewModel>>> GetAllRooms()
        {
            var data = _roomServices.GetAll();
            return ResponseViewModel<IEnumerable<RoomViewModel>>.Success(data);

        }


        // GET api/<RoomsController>/5
        [HttpGet]
        public async Task<ResponseViewModel<RoomViewModel>>  GetById(int id)
        {

            var data = await _roomServices.GetRoomById(id);
            return ResponseViewModel<RoomViewModel>.Success(data);
        }

        // POST api/<RoomsController>
        [HttpPost]
        public async Task<ResponseViewModel<string>> AddRoom([FromBody] CreateRoomDto roomDto)
        {
            var room = roomDto.Map<CreateRoomDto>();
            _roomServices.Add(room);
            return new SuccessResponseViewModel<string>(null);

        }

        // PUT api/<RoomsController>/5
        [HttpPut]
        public async Task<ResponseViewModel<string>> UpdateRoom(EditRoomDto roomDto)
        {
                var room = roomDto.Map<EditRoomDto>();
                _roomServices.Update(room);
                return new SuccessResponseViewModel<string>(null);
        }

        [HttpDelete("{id}")]
        public async Task<ResponseViewModel<string>> Delete(int id)
        {
            _roomServices.Delete(id);
            return new SuccessResponseViewModel<string>(null);

        }
    }
}
