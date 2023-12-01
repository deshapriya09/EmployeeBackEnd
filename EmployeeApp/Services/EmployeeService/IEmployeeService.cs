using EmployeeApp.Models;

namespace EmployeeApp.Services.EmployeeService
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAllEmployeeAsync();
        Task<Employee> GetEmployeeAsync(int id);
        Task<List<Employee>?> AddEmployeeAsync(Employee employee);
        Task<List<Employee>?> UpdateEmployeeAsync(Employee employee);
        Task<List<Employee>?> DeleteEmployeeAsync(int id);
        Task<List<Employee>> EmployeeSearch(string search);

    }
}
