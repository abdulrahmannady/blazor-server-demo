using EmployeeManagment.Core.Features.Department;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmployeeManagment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : Controller
    {
        private readonly Query query;

        public DepartmentController(Query query)
        {
            this.query = query;
        }

        [HttpGet]
        public async Task<IActionResult> GetDepartments()
        {
            try
            {
                var result = await query.GetDepartments();
                if (result is null)
                    return NotFound();

                return Ok(result);
            }
            catch (System.Exception e)
            {
                // Add logging for error
                return StatusCode(StatusCodes.Status500InternalServerError, "Error returning Data For Department");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetDepartment(int id)
        {
            try
            {
                var result = await query.GetDepartment(id);
                if (result is null)
                    return NotFound();

                return Ok(result);
            }
            catch (System.Exception e)
            {
                // Add logging for error
                return StatusCode(StatusCodes.Status500InternalServerError, "Error returning Data For Department");
            }
        }
    }
}
