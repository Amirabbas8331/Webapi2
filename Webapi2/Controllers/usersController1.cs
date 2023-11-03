using Microsoft.AspNetCore.Mvc;


namespace Webapi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usersController1 : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Amirabbas", "Ali" };
        }

        // GET api/<usersController1>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"value {id}";
        }

        // POST api/<usersController1>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<usersController1>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<usersController1>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
