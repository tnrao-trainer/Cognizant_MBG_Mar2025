using Microsoft.EntityFrameworkCore;

namespace WebApplication37.Models
{
    public class ApplicationDbContext  : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }
    }
}
