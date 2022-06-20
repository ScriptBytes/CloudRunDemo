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
            return "Like and subscribe!!!";
        }
    }
}
