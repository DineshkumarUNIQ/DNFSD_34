using Microsoft.EntityFrameworkCore;

namespace DNFSD_34.Models.Database
{
    public class ApplicationDB:DbContext
    {
        public ApplicationDB(DbContextOptions<ApplicationDB>op):base(op)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
