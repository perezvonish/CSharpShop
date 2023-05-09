using CsharpShop.Api.Dto;
using CsharpShop.Infrastucture;
using Microsoft.AspNetCore.Mvc;

namespace CsharpShop.Api.Controllers
{
    [Route("v1/admin")]
    [ApiController]
    public class AdminController : BaseController
    {
        public AdminController(ApplicationDbContext applicationDbContext) : base(applicationDbContext) { }

        [HttpPatch("makeAdmin")]
        public JsonResult MakeUserAdmin(MakeUserAdmin body) { return new JsonResult(body); }

        [HttpPatch("makeSeller")]
        public JsonResult MakeUserSeller(MakeUserSeller body) { return new JsonResult(body); }

        [HttpPatch("ban")]
        public JsonResult BanUser(BanUser body) { return new JsonResult(body); }
    }
}
