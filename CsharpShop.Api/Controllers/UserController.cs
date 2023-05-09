using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CsharpShop.Domain.Entities;
using CsharpShop.Infrastucture;
using CsharpShop.Api.Services;

namespace CsharpShop.Api.Controllers
{
    [Route("v1/user")]
    [ApiController]
    public class UserController : BaseController
    {
        private readonly UserService _userService;

        public UserController(ApplicationDbContext applicationDbContext, UserService userService) : base(applicationDbContext) {
            this._userService = userService;
        }

        [HttpGet("id")]
        public JsonResult GetUser(int id) {
            return new JsonResult(user);
        }

        [HttpGet("list")]
        public JsonResult GetUserList(User user)
        {
            return new JsonResult(user);
        }

        [HttpPost("create")]
        public JsonResult CreateUser(User user) {  return new JsonResult(user); }

        [HttpDelete("delete")]
        public JsonResult DeleteUser(User user) { return new JsonResult(user); }

        [HttpPatch("update")]
        public JsonResult UpdateUser(User user) { return new JsonResult(user);}

        [HttpPost("ban")]
        public JsonResult BanUser(User user) { return new JsonResult(user);}
    }
}
