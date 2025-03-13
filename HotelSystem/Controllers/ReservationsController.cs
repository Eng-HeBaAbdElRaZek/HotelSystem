using HotelSystem.Dto.Reservation;
using HotelSystem.Helpers;
using HotelSystem.Models;
using HotelSystem.Services;
using HotelSystem.ViewModel.Reservations;
using HotelSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {

        ReservationService _reservationService;
        public ReservationsController()
        {
            _reservationService = new ReservationService();
        }

        // GET: api/<ReservationsController>
        [HttpGet]
        public async Task<ResponseViewModel<IEnumerable<ReservationViewModle>>> GetAllReservations()
        {
            var data = _reservationService.GetAll();
            return ResponseViewModel<IEnumerable<ReservationViewModle>>.Success(data);

        }

        [HttpGet("{id}")]
        public async Task<ResponseViewModel<ReservationViewModle>> GetReservationsByCutId(int cutomerId)
        {
            var data = await _reservationService.GetReservationByCustId(cutomerId);
            return ResponseViewModel<ReservationViewModle>.Success(data);

        }

        // POST api/<ReservationsController>
        [HttpPost]
        public async Task<ResponseViewModel<string>> Post([FromBody] ReservationViewModle  reservationVm)
        {
            var reservation = reservationVm.Map<CreateReservationDto>();
            _reservationService.Add(reservation);
            return new SuccessResponseViewModel<string>(null);
        }

        // PUT api/<ReservationsController>/5
        [HttpPut("{id}")]
        public async Task<ResponseViewModel<string>> Put([FromBody] ReservationViewModle reservationVm)
        {
            var reservation = reservationVm.Map<EditReservationDto>();
            _reservationService.Update(reservation);
            return new SuccessResponseViewModel<string>(null);
        }

        // DELETE api/<ReservationsController>/5
        [HttpDelete("{id}")]
        public async Task<ResponseViewModel<string>> CancelReservation(int id)
        {
            _reservationService.CancelReservation(id);
            return new SuccessResponseViewModel<string>(null);
        }
    }
}
