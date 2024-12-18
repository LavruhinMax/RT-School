using Microsoft.EntityFrameworkCore;
using RT.Model;

namespace RT.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Objective> Objectives { get; set; }
    }
}
