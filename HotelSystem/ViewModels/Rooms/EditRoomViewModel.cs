﻿using HotelSystem.Models.Enums;

namespace HotelSystem.ViewModels.Rooms
{
	public class EditRoomViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public RoomType Type { get; set; }
		public decimal PricePerNight { get; set; }
		public List<IFormFile>? Pictures { get; set; }
		public List<int>? FacilityIds { get; set; }
	}
}
