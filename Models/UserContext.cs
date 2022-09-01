using Microsoft.EntityFrameworkCore;
using StartUpAcceloratorAPI.Models;
namespace StartUpAcceloratorAPI.Models
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(b => b.UserId)
                .HasName("UserId");
        }
        public DbSet<User> Users { get; set; } = null!;
    }
}
