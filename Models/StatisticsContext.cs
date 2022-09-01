using Microsoft.EntityFrameworkCore;
using StartUpAcceloratorAPI.Models;
namespace StartUpAcceloratorAPI.Models
{
    public class StatisticsContext:DbContext  
    {
        public StatisticsContext(DbContextOptions<StatisticsContext> options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Statistics>()
                .HasKey(b => b.id)
                .HasName("id");
        }
        public DbSet<Statistics> Statistics { get; set; } = null!;
    }
}
