using CsharpShop.Api.Dto;
using CsharpShop.Domain;
using CsharpShop.Domain.Entities;
using CsharpShop.Domain.Exceptions;

namespace CsharpShop.Api.Services
{
    public class AuthService
    {
        private readonly UserService _userService;

        public AuthService(UserService userService)
        {
            this._userService = userService;
        }

        public async Task<User> Register(AuthRegister data) {
            await Task.Run(() =>
            {
                if (this.CheckPasswordRepeat(data.Password, data.PasswordRepeat))
                {
                    Console.WriteLine("test");
                }
            });

            User user = new User(data.Username, data.Password, data.Email, data.Age);

            return this._userService.Create(user);
        }

        public async Task<User> Login(AuthLogin data)
        {
            User user = await this._userService.FindByUsername(data.Username);
            bool flag = this.CheckPassword(data.Password, user.Password);

            if (!flag)
            {
                throw new UnauthorizedAccessException(CustomExceptions.IncorrectPassword);
            }

            //todo add jwt strategy

            return user;
        }

        private bool CheckPasswordRepeat(string password, string passwordRepeat)
        {
            return password == passwordRepeat;
        }

        private bool CheckPassword(string password, string userPassword)
        {
            return password == userPassword;
        }
    }
}
