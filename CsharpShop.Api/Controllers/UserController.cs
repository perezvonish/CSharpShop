using Microsoft.AspNetCore.Mvc;
using CsharpShop.Domain.Entities;
using CsharpShop.Infrastucture;
using CsharpShop.Api.Services;
using CsharpShop.Domain.Dto;
using CsharpShop.Api.Dto;

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

        [HttpGet("{id: int}")]
        public User GetUser(int id)
        {
            return this._userService.GetUserById(id);
        }

        [HttpGet("list")]
        public User?[] GetUserList() //todo add pagination
        {
            return this._userService.GetUserList();
        }

        [HttpPost("create")]
        public User CreateUser(UserCreation body) {
            User user = new User(body);

            return this._userService.Create(user);
        }

        [HttpDelete("delete")]
        public async Task<User> DeleteUser(int id)
        {
            return await this._userService.Delete(id);
        }

        [HttpPatch("update")]
        public Task<User> UpdateUser(int id) { //todo add data
            return this._userService.UpdateAsync(id);
        }

        [HttpPost("ban")]
        public async Task<User> BanUser(UserBan body) {
            return await this._userService.Ban(body);
        }
    }
}
