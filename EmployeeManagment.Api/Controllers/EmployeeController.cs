using EmployeeMangament.Core.Features.Employee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmployeeManagment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly Management management;
        private readonly Query query;

        public EmployeeController(Management management, Query query)
        {
            this.query = query;
            this.management = management;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            try
            {
                var result = await query.GetEmployees();
                if (result is null)
                    return NotFound();

                return Ok(result);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error returning Data");
            }

        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            try
            {
                var result = await query.GetEmploye(id);
                if (result is null)
                    return NotFound();

                return Ok(result);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error single Data");
            }

        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateEmployee(EmployeeNewInput input)
        {
            try
            {
                if (input is null)
                    return BadRequest();

                var result = await management.Create(input);

                return CreatedAtAction(nameof(GetEmployee), new { id = result.Id }, result);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Adding single Data");
            }

        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateEmployee(EmployeeUpdateInput input)
        {
            try
            {
                if (input is null)
                    return BadRequest();

                var result = await management.Update(input);

                return Ok(result);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Update single Data");
            }

        }

        [HttpDelete("id:{int}")]
        public async Task<IActionResult> UpdateEmployee(int id)
        {
            try
            {
                var result = await management.Delete(id);
                if (result is null)
                    return NotFound();

                return Ok(result);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Delete single Data");
            }

        }
    }
}
