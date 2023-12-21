using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace CloudRunDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        [HttpGet(Name = "About")]
        public string Get()
        {
            return "Like and subscribe!!!!";
        }
        
        [HttpGet("testing", Name = "Testing")]
        public string Testing()
        {
            return "The TESTING env is: " + Environment.GetEnvironmentVariable("TESTING");
        }
    }
}
