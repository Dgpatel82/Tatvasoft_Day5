using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace Books_Day3.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]

    public class ValuesController : ControllerBase
    {
        [HttpGet("admin")]
        [Authorize(Policy="Admin")]
        public IActionResult GetAdminValue()
        {
            return Ok("This a value for Admins only");
        }

        [HttpGet("user")]
        [Authorize(Policy="user")]
        public IActionResult GetUserValue() {
            return Ok("This is value for Users Only");
        }

        [HttpGet("all")]
        [Authorize]
        public IActionResult GetAll()
        {
            return Ok("This is a value for all authenticated users.");
        }
    }
}
