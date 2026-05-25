using Microsoft.AspNetCore.Mvc;
using EmployeeApi.Models;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Sravani", Role = "Support", Salary = 30000 },
            new Employee { Id = 2, Name = "John", Role = "Developer", Salary = 50000 }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(employees);
        }
    }
}