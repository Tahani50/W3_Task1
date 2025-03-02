using EmployeeSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeSystem.Services
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
