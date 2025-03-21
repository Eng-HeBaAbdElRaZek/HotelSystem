﻿using HotelSystem.Models.Enum;

namespace HotelSystem.Models
{
    public class Staff :UserModel
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public IList<Reservation> Reservation { get; set; }

        public IList<Room> Rooms { get; set; }

    }
}
