using HotelSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelSystem.Configrations
{
    public class FacilitieConfigration : IEntityTypeConfiguration<Facilitie>
    {
        public void Configure(EntityTypeBuilder<Facilitie> builder)
        {
            builder.HasKey(x => x.Id);

        }
    }
}
