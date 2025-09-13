using Microsoft.AspNetCore.Mvc;

namespace projectASP.Controllers
{
    [ApiController]
    [Route("api/helloworld")]
    public class HelloWorld : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new {message = "Hello world"});
        }
    }
}
