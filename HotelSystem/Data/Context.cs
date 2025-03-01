using HotelSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace HotelSystem.Data
{
	public class Context : DbContext
	{
		public DbSet<Facility> Facilities { get; set; }
		public DbSet<FeedBack> FeedBacks { get; set; }
		public DbSet<Offer> Offers { get; set; }
		public DbSet<Reservation> Reservations { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<Room> Rooms { get; set; }
		public DbSet<RoomFacility> RoomFacilities { get; set; }
		public DbSet<RoomOffer> RoomOffers { get; set; }
		public DbSet<RoomPicture> RoomPictures { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<UserRole> UserRoles { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data source =.\sqlExpress;initial catalog = ExaminationSystem; integrated security = true; trust server certificate=true")
				.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
				.LogTo(log => Debug.WriteLine(log), LogLevel.Information)
				.EnableSensitiveDataLogging();
		}

	}
}
