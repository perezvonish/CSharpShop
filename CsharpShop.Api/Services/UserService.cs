using CsharpShop.Domain;
using CsharpShop.Domain.Entities;
using CsharpShop.Domain.Exceptions;
using CsharpShop.Infrastucture.Repositories;
using System.ComponentModel;

namespace CsharpShop.Api.Services
{
    public class UserService
    {
        private readonly UsersRepository usersRepository;

        public UserService(UsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public async Task<User> FindByUsername(string username)
        {
            User? user = null;
            await Task.Run(() =>
            {
                user = this.usersRepository.FindByUsername(username);
            });

            if (user == null)
            {
                throw new KeyNotFoundException(CustomExceptions.UserNotFound);
            }

            return user;
        }

        public async Task<User> GetUserById(int id)
        {
            User? user = null;
            await Task.Run(() =>
            {
                user = this.usersRepository.GetUserById(id);
            });

            if (user == null)
            {
                throw new KeyNotFoundException(CustomExceptions.UserNotFound);
            }

            return user;
        }

        public User Create(User data)
        {
            return this.usersRepository.Create(data);
        }
    }
}
