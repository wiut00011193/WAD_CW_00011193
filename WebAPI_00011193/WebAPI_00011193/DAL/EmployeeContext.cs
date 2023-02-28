using Microsoft.EntityFrameworkCore;
using WebAPI_00011193.Models;

namespace WebAPI_00011193.DAL
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> o) : base(o)
        {
            Database.EnsureCreated();
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
