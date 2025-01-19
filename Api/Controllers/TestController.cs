using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Controller]
    [Route("api/v1/[controller]/")]
    public class TestController : Controller
    {
        [HttpGet]
        public ActionResult GetMessage()
        {
            return Ok("Hello World!");
        }
    }
}
