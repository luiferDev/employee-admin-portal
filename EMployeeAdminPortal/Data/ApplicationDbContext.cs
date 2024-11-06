using EMployeeAdminPortal.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EMployeeAdminPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        //{ hacer el contructor manualmente

        //}
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
