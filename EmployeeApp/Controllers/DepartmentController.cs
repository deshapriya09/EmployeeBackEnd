using EmployeeApp.Models;
using EmployeeApp.Services.DepartmentService;
using EmployeeApp.Services.EmployeeService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet("GetAllDepartment")]
        public async Task<ActionResult<List<Department>>> GetAllDepartmentAsync()
        {
            var result = await _departmentService.GetAllDepartmentAsync();
            {
                if (result == null)
                {
                    return NotFound("Department not found");
                }
                return Ok(result);
            }
        }

    }
}
