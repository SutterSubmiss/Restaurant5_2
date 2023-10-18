using Microsoft.EntityFrameworkCore;

namespace Restaurant5.Web.Models
{
    public class RestaurantContext:DbContext
    {
        public DbSet<Users> Users { get; set; }

        public RestaurantContext(DbContextOptions options) : base(options)
        {

        }
    }
}
