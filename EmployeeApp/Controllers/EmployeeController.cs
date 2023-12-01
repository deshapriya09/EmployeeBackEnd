using EmployeeApp.Models;
using EmployeeApp.Services.EmployeeService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("GetAllEmployee")]
        public async Task<ActionResult<List<Employee>>> GetAllEmployeeAsync()
        {
            var result = await _employeeService.GetAllEmployeeAsync();
            {
                if (result == null)
                {
                    return NotFound("Employee not found");
                }
                return Ok(result);
            }
        }

        [HttpGet("GetEmployeeDetailsById/{id}")]
        public async Task<ActionResult<Employee>> GetEmployeeAsync(int id)
        {
            var result = await _employeeService.GetEmployeeAsync(id);
            if (result == null)
            {
                return NotFound("Employee not found");
            }
            return Ok(result);
        }

        [HttpPost("AddEmployee")]
        public async Task<ActionResult<List<Employee>>> AddEmployeeAsync([FromBody] Employee employee)
        {
            var result = await _employeeService.AddEmployeeAsync(employee);
            return Ok(result);
        }

        [HttpPut("UpdateEmployee")]
        public async Task<ActionResult<List<Employee>>> UpdateEmployeeAsync([FromBody] Employee employee)
        {
            var result = await _employeeService.UpdateEmployeeAsync(employee);
            if (result == null)
            {
                return NotFound("Employee not found");
            }
            return Ok(result);
        }

        [HttpDelete("DeleteEmployeeDetailsById/{id}")]
        public async Task<ActionResult<List<Employee>>> DeleteEmployeeAsync(int id)
        {
            var result = await _employeeService.DeleteEmployeeAsync(id);

            return Ok(result);
        }

        [HttpGet("EmployeeSearch")]
        public async Task<ActionResult<List<Employee>>> EmployeeSearch(string search)
        {
            var aircrafts = await _employeeService.EmployeeSearch(search);
            return (aircrafts);
        }
    }
}
