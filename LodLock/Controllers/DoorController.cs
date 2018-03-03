using System.IO;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Z;

namespace LodLock.Controllers
{
    [Produces("application/json")]
    public class DoorController : Controller
    {
        private ZApi api = new ZApi();
        [HttpPost]
        [Route("main")]
        public IActionResult Main(IFormFile message,[FromHeader]byte[] data)
        {
            var headers = Request.Headers.ToArray();
            api.init("85.143.104.47:1111");
            var controllers = api.GetControllers();
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                var body=reader.ReadToEnd();
            }
            return Ok();
        }
    }
}