using AutoMapper.QueryableExtensions;
using HotelSystem.Dto.Reservations;
using HotelSystem.Dto.Reservations;
using HotelSystem.Helpers;
using HotelSystem.Models;
using HotelSystem.Repository;
using HotelSystem.ViewModel.Reservations;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;

namespace HotelSystem.Services
{
    public class ReservationService
    {
        GeneralRepository<Reservation> _reservationRep;
        GeneralRepository<Room> _roomRepo;
        public ReservationService()
        {
            _reservationRep = new GeneralRepository<Reservation>();
            _roomRepo = new GeneralRepository<Room>();
        }

        public async void Add(CreateReservationDto reservationDto)
        {

            var reservation = reservationDto.Map<Reservation>();
            _reservationRep.Add(reservation);
        }

        public async void Update(EditReservationDto reservationDto)
        {
            var room = _roomRepo.GetByID(reservationDto.RoomId);
            
            var reservation =  reservationDto.Map<Reservation>();

            if (reservation.RoomId == room.Id)
            {
                _reservationRep.UpdateInclude(reservation, nameof(reservation.CheckOn), nameof(reservation.CheckOut));

            }
            else
            {
                NotFound("This room has no reservations. ");
            }

        }

        public IEnumerable<ReservationViewModle> GetAll()
        {
            var query = GetReservation();
            return query.Project<ReservationViewModle>();
        }

        public async void CancelReservation(int id)
        {
            var query = await _reservationRep.GetByID(id);
            query.Canceled = true;
        }

        public IQueryable<Reservation> GetReservation()
        {
            return _reservationRep.GetAll();
        }

        public async Task<ReservationViewModle> GetReservationByCustId(int customerId)
        {
            var data = _reservationRep.GetAll();

            return await data.Where(c => c.CustomerId == customerId)
                .Project<ReservationViewModle>()
                .FirstOrDefaultAsync();
        }

        public string Error { get; set; }
        public string NotFound(string error)
        {
            return Error = error;
        }
    }
}
