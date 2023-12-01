using EmployeeApp.Data;
using EmployeeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApp.Services.DepartmentService
{
    public class DepartmentService : IDepartmentService
    {
        private readonly DataContext _context;

        public DepartmentService(DataContext context)
        {
            _context = context;

        }

        public async Task<List<Department>> GetAllDepartmentAsync()
        {
            var departments = await _context.Department.ToListAsync();
            return departments;
        }
    }

    
}
