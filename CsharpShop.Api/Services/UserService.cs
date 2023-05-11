using CsharpShop.Api.Dto;
using CsharpShop.Domain;
using CsharpShop.Domain.Entities;
using CsharpShop.Domain.Exceptions;
using CsharpShop.Infrastucture.Repositories;
using System.ComponentModel;

namespace CsharpShop.Api.Services
{
    public class UserService
    {
        private readonly UsersRepository _usersRepository;

        public UserService(UsersRepository usersRepository)
        {
            this._usersRepository = usersRepository;
        }

        public async Task<User> FindByUsername(string username)
        {
            User? user = null;
            await Task.Run(() =>
            {
                user = this._usersRepository.FindByUsername(username);
            });

            return user == null ? throw new KeyNotFoundException(CustomExceptions.UserNotFound) : user;
        }

        public User GetUserById(int id)
        {
            User? user = this._usersRepository.GetUserById(id);

            return user ?? throw new KeyNotFoundException(CustomExceptions.UserNotFound);
        }

        public User?[] GetUserList()
        {
            //todo add where condition

            User?[] users = this._usersRepository.GetUserList();

            return users;
        }

        public User Create(User data)
        {
            return this._usersRepository.Create(data);
        }

        public async Task<User> Delete(int id)
        {
            User? user = await Task.Run(() => this.GetUserById(id));

            return this._usersRepository.Delete(user);
        }

        public async Task<User> UpdateAsync(int id)
        {
            User? user = await Task.Run(() => this.GetUserById(id));

            return this._usersRepository.Update(user);
        }

        public async Task<User> Ban(UserBan data)
        {
            User? user = await Task.Run(() => this.GetUserById(data.Id));

            return this._usersRepository.Ban(user, data.Flag, data.UserBanReason);
        }
    }
}
