using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CsharpShop.Api.Controllers
{
    [Route("v1/health")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet("check")]
        public Boolean Health()
        {
            return true;
        }
    }
}
