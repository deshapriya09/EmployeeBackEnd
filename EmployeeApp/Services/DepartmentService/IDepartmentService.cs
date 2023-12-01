using EmployeeApp.Models;

namespace EmployeeApp.Services.DepartmentService
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetAllDepartmentAsync();
    }
}
