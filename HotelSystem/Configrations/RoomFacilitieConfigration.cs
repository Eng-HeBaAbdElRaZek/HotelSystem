using HotelSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelSystem.Configrations
{
    public class RoomFacilitieConfigration : IEntityTypeConfiguration<RoomFacilitie>
    {
        public void Configure(EntityTypeBuilder<RoomFacilitie> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Facilitie)
                .WithMany(x => x.Facilities)
                .HasForeignKey(x => x.FacilitieId);

            builder.HasOne(x => x.Room)
               .WithMany(x => x.Facilities)
               .HasForeignKey(x => x.RoomId);


        }
    }
}
