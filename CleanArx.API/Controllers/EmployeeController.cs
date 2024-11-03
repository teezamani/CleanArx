using CleanArx.Application.Command.EmployeeCommand;
using CleanArx.Application.Queries.EmployeeQueries;
using CleanArx.Core.Entity;
using CleanArx.Core.Options;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CleanArx.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(ISender sender , IOptions<AppSettings> appSettings) : ControllerBase
    {
        [HttpPost("AddEmployee")]
        public async Task<IActionResult> AddEmployeeAsync([FromBody] Employee employee)
        {
            var result = await sender.Send(new AddEmployeeCommand(employee));
            return Ok(result);
        }


        [HttpGet("GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployeesAsync()
        {
            var env = appSettings.Value.DefaultConnection;

            var result = await sender.Send(new GetAllEmployeesQuery());
            return Ok(result);
        }

        [HttpGet("{employeeId}")]
        public async Task<IActionResult> GetEmployeeByIdAsync([FromRoute] Guid employeeId)
        {
            var result = await sender.Send(new GetEmployeeByIdQuery(employeeId));
            return Ok(result);
        }

        [HttpPut("{employeeId}")]
        public async Task<IActionResult> UpdateEmployeeAsync([FromRoute] Guid employeeId, [FromBody] Employee employee)
        {
            var result = await sender.Send(new UpdateEmployeeCommand(employeeId, employee));
            return Ok(result);
        }

        [HttpDelete("{employeeId}")]
        public async Task<IActionResult> DeleteEmployeeAsync([FromRoute] Guid employeeId)
        {
            var result = await sender.Send(new DeleteEmployeeCommand(employeeId));
            return Ok(result);
        }
    }

 }
