using HotelSystem.Dto.Rooms.Facilities;
using HotelSystem.Helpers;
using HotelSystem.Services;
using HotelSystem.ViewModel.Rooms.Facilities;
using HotelSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace HotelSystem.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FacilitiesController : ControllerBase
    {

        FacilitieServices _facilitieServices;
        public FacilitiesController()
        {

            _facilitieServices = new FacilitieServices();
        }

        // GET api/<FacilitiesController>/5
        [HttpGet]
        public async Task<ResponseViewModel<IEnumerable<FacilitieViewModel>>> GetAllFacilities()
        {
            var data = _facilitieServices.GetAll();
            return ResponseViewModel<IEnumerable<FacilitieViewModel>>.Success(data);

        }


        // GET api/<FacilitiesController>/5
        [HttpGet]
        public async Task<ResponseViewModel<FacilitieViewModel>> GetById(int id)
        {

            var data = await _facilitieServices.GetFacilitieById(id);
            return ResponseViewModel<FacilitieViewModel>.Success(data);
        }


        // POST api/<FacilitiesController>
        [HttpPost]

        public async Task<ResponseViewModel<string>> AddFailitie([FromBody] CreateFaciliteDto faciliteDto)
        {
            var facilitie = faciliteDto.Map<CreateFaciliteDto>();
            _facilitieServices.CreateFacilitie(facilitie);
            return new SuccessResponseViewModel<string>(null);

        }


        // PUT api/<FacilitiesController>/5
        [HttpPut]
        public async Task<ResponseViewModel<string>> UpdateFacilitie(EditeFaciliteDto faciliteDto)
        {
            var facilitie = faciliteDto.Map<EditeFaciliteDto>();
            _facilitieServices.UpdateFacilitie(facilitie);
            return new SuccessResponseViewModel<string>(null);
        }


        // DELETE api/<FacilitiesController>/5
        [HttpDelete("{id}")]
        public async Task<ResponseViewModel<string>> Delete(int id)
        {
            _facilitieServices.Delete(id);
            return new SuccessResponseViewModel<string>(null);

        }
    }
}
