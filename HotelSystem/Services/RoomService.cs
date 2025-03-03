using HotelSystem.DTOs.Rooms;
using HotelSystem.Helpers;
using HotelSystem.Models;
using HotelSystem.Repository;

namespace HotelSystem.Services
{
	public class RoomService
	{
		GeneralRepository<Room> _roomRepository;
		FileManager _fileManager;
		public RoomService()
		{
			_roomRepository = new GeneralRepository<Room>();
			_fileManager = new FileManager();
		}

		public async void Add(CreateRoomDto roomDto)
		{

			var room = roomDto.Map<Room>();
			if (roomDto.Pictures != null && roomDto.Pictures.Any())
			{
				room.RoomPictures = new List<RoomPicture>();

				foreach (var file in roomDto.Pictures)
				{
					var imageUrl = await _fileManager.SaveFile(file);
					room.RoomPictures.Add(new RoomPicture { PictureURL = imageUrl });
				}
			}
			_roomRepository.Add(room);
		}

		public void Update(EditRoomDto roomDto)
		{
			var room = roomDto.Map<Room>();
			_roomRepository.UpdateInclude(room, nameof(room.Name), nameof(room.Type), nameof(room.PricePerNight));

		}

		public IEnumerable<RoomDto> GetAll()
		{
			var query = GetRooms();
			return query.Project<RoomDto>();
		}

		public void DeleteRoom(int id)
		{
			_roomRepository.Delete(id);
		}

		private IQueryable<Room> GetRooms()
		{
			return _roomRepository.Get();
		}
	}
}
