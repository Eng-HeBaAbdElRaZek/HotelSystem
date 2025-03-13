using HotelSystem.Dto.Reservations;
using HotelSystem.Dto.Rooms;
using HotelSystem.Helpers;
using HotelSystem.Models;
using HotelSystem.Repository;
using HotelSystem.ViewModel.Reservations;
using HotelSystem.ViewModel.Rooms;

namespace HotelSystem.Services
{
    public class RoomServices
    {
        GeneralRepository<Room> _roomRepo;

        public RoomServices()
        {
            _roomRepo = new GeneralRepository<Room>();
        }


        public async void Add(CreateRoomDto roomDto)
        {

            var room = roomDto.Map<Room>();
            _roomRepo.Add(room);
        }

        public async void Update(EditRoomDto roomDto)
        {
            var room = await _roomRepo.GetByID(roomDto.Id);


            if (room.Id != null)
            {
                _roomRepo.UpdateInclude(room, nameof(room.Type), nameof(room.PricePerNight));

            }
            else
            {
                NotFound("This room is not Existing. ");
            }

            room = roomDto.Map<Room>();
            _roomRepo.Update(room);


        }

        public IEnumerable<RoomViewModel> GetAll()
        {
            var query = _roomRepo.GetAll();
            return query.Project<RoomViewModel>();
        }

        public async Task<RoomViewModel> GetRoomById(int id)
        {
            var query = await _roomRepo.GetByID(id);
            return query.Map<RoomViewModel>();
        }

        public async void Delete(int id)
        {
            var query = await _roomRepo.GetByID(id);
            _roomRepo.Delete(query.Id);
        }


        public string Error { get; set; }
        public string NotFound(string error)
        {
            return Error = error;
        }
    }
}
