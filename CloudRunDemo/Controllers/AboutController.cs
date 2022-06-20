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
            return "This is a simple .Net 6 API to demo Cloud Run and Cloud Build";
        }
    }
}
