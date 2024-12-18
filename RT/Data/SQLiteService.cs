using Microsoft.EntityFrameworkCore;
using RT.Model;
using RT.Service;

namespace RT.Data
{
    public class SQLiteService
    {
        private readonly AppDbContext _context;
        public SQLiteService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Supervisor>> getSupervisorsAsync()
        {
            return await _context.Supervisors.ToListAsync();
        }
        public async Task<List<Employee>> getEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }
        public async Task<List<Course>> getCoursesAsync()
        {
            return await _context.Courses.ToListAsync();
        }
        public async Task<List<Account>> getAccountsAsync()
        {
            return await _context.Accounts.ToListAsync();
        }
        public async Task<List<Objective>> getEmployee_Courses()
        {
            return await _context.Objectives.ToListAsync();
        }

        public async Task updateEmployee()
        {
            var existingEmployee = await _context.Employees.FindAsync(UserContext.id);

            existingEmployee.Phone_Number = UserContext.phoneNumber;
            existingEmployee.Email = UserContext.email;

            await _context.SaveChangesAsync();
        }
    }
}
