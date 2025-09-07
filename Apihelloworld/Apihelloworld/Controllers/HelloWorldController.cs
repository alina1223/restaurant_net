using Microsoft.AspNetCore.Mvc;

namespace Apihelloworld.Controllers
{
    [ApiController]
    [Route("api/helloworld")]  
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Hello, world!" });
        }
    }
}
