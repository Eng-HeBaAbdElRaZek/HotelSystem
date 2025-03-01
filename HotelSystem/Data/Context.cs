using HotelSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace HotelSystem.Data
{
    public class Context : DbContext
    {




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source =.\sqlExpress;initial catalog = ExaminationSystem; integrated security = true; trust server certificate=true")
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                .LogTo(log => Debug.WriteLine(log), LogLevel.Information)
                .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomFacility>()
                .HasKey(rf => new { rf.RoomId, rf.FacilityId });

            modelBuilder.Entity<RoomFacility>()
                .HasOne(rf => rf.Room)
                .WithMany(r => r.RoomFacilities)
                .HasForeignKey(rf => rf.RoomId);

            modelBuilder.Entity<RoomFacility>()
            .HasOne(rf => rf.Facility)
            .WithMany(f => f.RoomFacilities)
            .HasForeignKey(rf => rf.FacilityId);

            base.OnModelCreating(modelBuilder);
        }



         
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<RoomFacility> RoomFacilities { get; set; }




    }
}
