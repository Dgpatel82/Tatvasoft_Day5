using Microsoft.EntityFrameworkCore;
using Books_Day3.Models;

namespace Books_Day3.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions < BookDbContext > options) : base(options)
        { 
        }

        
        public DbSet<User>Users { get; set; }
        public DbSet<Role>Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany()
                .HasForeignKey(u => u.RoleId);
        }
    }
}
