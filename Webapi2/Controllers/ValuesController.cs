using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Webapi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
     
        [HttpGet]
        public IActionResult Get(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            bool areCollinear = (y3 - y2) * (x2 - x1) == (y2 - y1) * (x3 - x2);
            return Ok(new { x1, y1, x2, y2, x3, y3, areCollinear });
        }
    }
}
    