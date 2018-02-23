using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LodLock.Controllers
{
    [Produces("application/json")]
    public class DoorController : Controller
    {
        [HttpPost]
        [Route("main")]
        public IActionResult Main(IFormFile message, [FromHeader]string xSerN, [FromHeader] string xAuthKey)
        {
            return Ok();
        }
    }
}