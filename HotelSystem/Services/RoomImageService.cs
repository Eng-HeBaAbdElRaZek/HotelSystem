using HotelSystem.Dto.Rooms;
using HotelSystem.Dto.Rooms.Images;
using HotelSystem.Helpers;
using HotelSystem.Models;
using HotelSystem.Repository;
using HotelSystem.ViewModel.Rooms;
using HotelSystem.ViewModel.Rooms.Images;

namespace HotelSystem.Services
{
    public class RoomImageService
    {
        GeneralRepository<RoomImage> _roomImgRepo;

        public RoomImageService(GeneralRepository<RoomImage> roomImgRepo)
        {
                
            _roomImgRepo = roomImgRepo; 
        }

        public async void Add(CreateRoomImageDto roomImgDto)
        {

            var roomImg = roomImgDto.Map<RoomImage>();
            _roomImgRepo.Add(roomImg);
        }

        public async void Update(EditeRoomImageDto roomImgDto)
        {
            var roomImg = await _roomImgRepo.GetByID(roomImgDto.Id);


            if (roomImg.Id != null)
            {
                _roomImgRepo.UpdateInclude(roomImg, nameof(roomImg.ImgUrl));

            }
            else
            {
                NotFound("This room is not Existing. ");
            }

            roomImg = roomImgDto.Map<RoomImage>();
            _roomImgRepo.Update(roomImg);


        }

        public IEnumerable<RoomImgViewModel> GetAll()
        {
            var query = _roomImgRepo.GetAll();
            return query.Project<RoomImgViewModel>();
        }

        public async Task<RoomImgViewModel> GetRoomById(int id)
        {
            var query = await _roomImgRepo.GetByID(id);
            return query.Map<RoomImgViewModel>();
        }

        public async void Delete(int id)
        {
            var query = await _roomImgRepo.GetByID(id);
            _roomImgRepo.Delete(query.Id);
        }


        public string Error { get; set; }
        public string NotFound(string error)
        {
            return Error = error;
        }
    }
}
}
