using CsharpShop.Domain;
using CsharpShop.Domain.Entities;

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

        public User? FindByUsername(string username)
        {
            return this._context.Users.Find(username);
        }

        public User? GetUserById(int id)
        {
            return this._context.Users.Find(id);
        }
    }
}
