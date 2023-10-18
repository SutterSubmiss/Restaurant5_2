using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Restaurant5.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<DishesEntity> Dishes { get; set; }
        public DbSet<UsersEntity> Users { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}