using Microsoft.EntityFrameworkCore;

namespace BackEnd.Models
{
    public class ApplicationDbContext : DbContext // colon means inherit from this other class
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)

        {

        }

        public DbSet<Speaker> Speakers { get; set; }
    }
}
