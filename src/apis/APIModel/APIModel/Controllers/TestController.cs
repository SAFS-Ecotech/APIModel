using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIModel.Controllers
{
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("api/test")]
        public async Task<ActionResult<string>> TestApi()
        {
            return "Hello world";
        }
    }
}
