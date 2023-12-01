using EmployeeApp.Data;
using EmployeeApp.Models;

namespace EmployeeApp.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private static List<Employee> employees = new List<Employee>();
            
        private readonly DataContext _context;

        public EmployeeService(DataContext context)
        {
            _context = context;
        
        }

        public async Task<List<Employee>?> AddEmployeeAsync(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return await _context.Employees.ToListAsync();
        }

        public async Task<List<Employee>?> DeleteEmployeeAsync(int id)
        {
            var deleteEmployee = await _context.Employees.FindAsync(id);
            if (deleteEmployee == null)
            {
                return null;
            }
            _context.Employees.Remove(deleteEmployee);
            await _context.SaveChangesAsync();

            return await _context.Employees.ToListAsync();
        }

        public async Task<List<Employee>> GetAllEmployeeAsync()
        {
            var employees = await _context.Employees.ToListAsync();
            return employees;
        }

        public async Task<Employee> GetEmployeeAsync(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return null;
            }
            return employee;
        }

        public async Task<List<Employee>?> UpdateEmployeeAsync(Employee employee)
        {
            var updatedemployee = await _context.Employees.FindAsync(employee.Id);
            if (employee == null)
            {
                return null;
            }
            updatedemployee.FirstName = employee.FirstName;
            updatedemployee.LastName = employee.LastName;
            updatedemployee.LastName = employee.Gender;
            updatedemployee.DateOfBirth = employee.DateOfBirth;
            updatedemployee.Address = employee.Address;
            updatedemployee.DepartmentId = employee.DepartmentId;
            updatedemployee.BasicSalary = employee.BasicSalary;

            await _context.SaveChangesAsync();

            return await _context.Employees.ToListAsync();
        }

        public async Task<List<Employee>> EmployeeSearch(string search)
        {
            var result = await _context.Employees.Where(ac => EF.Functions.Like(ac.FirstName, $"%{search}%") || EF.Functions.Like(ac.LastName, $"%{search}%") || EF.Functions.Like(ac.Address, $"%{search}%")).ToListAsync();
            return result;
        }
    }
}
