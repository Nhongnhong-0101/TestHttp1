using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestHttp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] TestData data)
        {
            if (data == null || string.IsNullOrEmpty(data.Value))
            {
                return BadRequest("Invalid data.");
            }
            return Ok($"Received: {data.Value}");
        }

    }
    public class TestData
    {
        public string Value { get; set; }
    }
}
