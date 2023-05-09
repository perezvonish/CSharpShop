using CsharpShop.Domain.Enums;

namespace CsharpShop.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public bool IsBanned { get; set; } = false;
        public UserBanReasons? BanReason { get; set; } = null;
        public bool IsAdmin { get; set; } = false;  
        public bool IsSeller { get; set; } = false;

        public User(string username, string password, string email, int age) {
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.Age = age;
        }
    }
}
