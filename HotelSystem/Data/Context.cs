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

    }
}
