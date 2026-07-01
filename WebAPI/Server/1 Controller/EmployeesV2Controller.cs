using Microsoft.AspNetCore.Mvc;
using WebAPI.Server._2_ServiceLayer;
using WebAPI.Server.Model;

namespace WebAPI.Server._1_Controller
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]

    public class EmployeesV2Controller : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeesV2Controller(
            IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var employees = await _service.GetAllAsync();

            return Ok(employees);
        }
        // [HttpGet("{id}")]

        //public async Task<IActionResult> GetById(int id)
        //{
        //    var employee =
        //        await _service.GetByIdAsync(id);

        //    if (employee == null)
        //        return NotFound();

        //    return Ok(employee);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Create(Employee employee)
        //{
        //    await _service.AddAsync(employee);

        //    return CreatedAtAction(
        //        nameof(GetById),
        //        new { id = employee.Id },
        //        employee);
        //}
    }
}
