using CsharpShop.Infrastucture;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CsharpShop.Api.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    
    {
        private readonly ApplicationDbContext _context;

        public BaseController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
