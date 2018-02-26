using System.IO;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LodLock.Controllers
{
    [Produces("application/json")]
    public class DoorController : Controller
    {
        [HttpPost]
        [Route("main")]
        public IActionResult Main(IFormFile message,[FromHeader]string data)
        {
            var headers = Request.Headers.ToArray();
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                var body=reader.ReadToEnd();
            }
            return Ok();
        }
    }
}