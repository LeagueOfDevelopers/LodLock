using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LodLock.Controllers
{
    [Produces("application/json")]
    public class DoorController : Controller
    {
        [HttpPost]
        [Route("main")]
        public IActionResult Main(
            IFormFile message, 
            [FromHeader]string X_SER_N, 
            [FromHeader]Stream data)
        {
            var body=new StreamReader(data).ReadToEndAsync();
            return Ok();
        }
    }
}