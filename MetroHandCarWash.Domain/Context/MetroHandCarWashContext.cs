using Microsoft.EntityFrameworkCore;
namespace MetroHandCarWash.Domain.Context
{
    public class MetroHandCarWashContext : DbContext
    {
        public MetroHandCarWashContext(DbContextOptions<MetroHandCarWashContext> options)
    : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<Client> Client { get; set; }
    }
}