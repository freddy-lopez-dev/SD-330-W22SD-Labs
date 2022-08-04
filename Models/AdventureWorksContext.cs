using Microsoft.EntityFrameworkCore;

namespace SD_330_W22SD_Labs.Models
{
    public class AdventureWorksContext : DbContext
    {
        public AdventureWorksContext (DbContextOptions<AdventureWorksContext> options) : base(options)
        {

        }

        public DbSet<SD_330_W22SD_Labs.Models.Customer> Customer { get; set; } = default!;
        public DbSet<SD_330_W22SD_Labs.Models.Address> Address { get; set; } = default!;
    }
}
