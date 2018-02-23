using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LodLock.Controllers
{
    [Produces("application/json")]
    public class DoorController : Controller
    {
        [HttpPost]
        [Route("main")]
        public IActionResult Main()
        {
            //main
            return Ok();
        }
    }
}