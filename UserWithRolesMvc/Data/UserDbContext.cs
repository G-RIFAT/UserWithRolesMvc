using Microsoft.EntityFrameworkCore;
using UserWithRolesMvc.Models;

namespace UserWithRolesMvc.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(Microsoft.EntityFrameworkCore.DbContextOptions<UserDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FirstName = "Akib", LastName = "Rahman", Role = "Admin" },
                new User { Id = 2, FirstName = "Riyadh", LastName = "Khan", Role = "Salesman" },
                new User { Id = 3, FirstName = "Taslima", LastName = "Akter", Role = "Manager" },
                new User { Id = 4, FirstName = "Jamal", LastName = "Uddin", Role = "Salesman" }
            );
        }

    }

}
