using CsharpShop.Domain;
using CsharpShop.Domain.Entities;
using CsharpShop.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace CsharpShop.Infrastucture.Repositories
{
    public class UsersRepository
    {
        private readonly ApplicationDbContext _context;

        public UsersRepository(ApplicationDbContext context) {
            _context = context;
        }

        public User Create(User user)
        {
            this._context.Users.Add(user);
            this._context.SaveChanges();
            return user;
        }

        public User Delete(User user)
        {
            this._context.Users.Remove(user);
            this._context.SaveChanges();

            return user;
        }

        public User Update(User user) //todo add data
        {
            return user; //todo add update
        }

        public User? FindByUsername(string username)
        {
            return this._context.Users.Find(username);
        }

        public User? GetUserById(int id)
        {
            return (User?)this._context.Users.Where((user) => user.Id == id).First();
        }

        public User[] GetUserList()
        {
            return this._context.Users.ToList().ToArray(); //todo add where condition type
        }

        public User Ban(User userData, bool flag, UserBanReasons? banReason)
        {
            userData.IsBanned = flag;
            userData.BanReason = banReason ?? null;

            this._context.SaveChanges();

            return userData;
        }
    }
}
