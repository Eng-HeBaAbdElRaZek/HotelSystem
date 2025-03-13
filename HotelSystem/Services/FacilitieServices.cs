using HotelSystem.Dto.Rooms.Facilities;
using HotelSystem.Helpers;
using HotelSystem.Models;
using HotelSystem.Repository;
using HotelSystem.ViewModel.Rooms.Facilities;

namespace HotelSystem.Services
{
    public class FacilitieServices
    {
        GeneralRepository<Facilitie> _facilitieRepo;
        RoomServices _roomServices;

        public FacilitieServices()
        {
            _facilitieRepo = new GeneralRepository<Facilitie>();
            _roomServices = new RoomServices();

        }

        public async void CreateFacilitie(CreateFaciliteDto facilitieDto)
        {
            var newFacilitie = facilitieDto.Map<Facilitie>();
             _facilitieRepo.Add(newFacilitie);
        }

        public async void UpdateFacilitie(EditeFaciliteDto facilitieDto)
        {
            var facilitie = await _facilitieRepo.GetByID(facilitieDto.Id);
            if (facilitie.Id != null)
            {
                _facilitieRepo.UpdateInclude(facilitie, nameof(facilitie.Name));
            }
            else
            {
                NotFound("This facilitie is not Existing. ");
            }
            facilitie = facilitieDto.Map<Facilitie>();
            _facilitieRepo.Update(facilitie);
        }

        public IEnumerable<FacilitieViewModel> GetAll()
        {
            var query = _facilitieRepo.GetAll();
            return query.Project<FacilitieViewModel>();
        }

        public async Task<FacilitieViewModel> GetFacilitieById(int id)
        {
            var query = await _facilitieRepo.GetByID(id);
            return query.Map<FacilitieViewModel>();
        }


        public async void Delete(int id)
        {
            var roomFacilitie = await _roomServices.GetRoomById(id);
            var query = await _facilitieRepo.GetByID(id);
            //if (query. )
            //{
            //    NotFound("Can not delete this facilitie becaues there is some data realte it . ");
            //}
            _facilitieRepo.Delete(query.Id);
        }

        public string Error { get; set; }
        public string NotFound(string error)
        {
            return Error = error;
        }
    }
}
