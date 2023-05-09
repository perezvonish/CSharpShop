using CsharpShop.Api.Dto;
using CsharpShop.Api.Services;
using CsharpShop.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CsharpShop.Api.Controllers
{
    [Route("v1/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly AuthService _authService;

        public AuthController(AuthService authService) 
        {
            this._authService = authService;
        }

        [HttpPost("register")]
        public async Task<User> Register(AuthRegister body)
        {
            return await this._authService.Register(body);
        }

        [HttpPost("login")]
        public async Task<User> Login(AuthLogin body)
        {
            return await this._authService.Login(body);
        }
    }
}
