using Microsoft.EntityFrameworkCore;
using scooter_api.Scooters.Models;

namespace scooters_api.Data.Migrations
{
    public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Scooter> Scooter { get; set; }

    }
}
