using System.ComponentModel.DataAnnotations;

namespace CsharpShop.Api.Dto
{
    public class MakeUserAdmin {
        [Required]
        public int userId { get; set; }
        [Required]
        public bool flag { get; set; }
    }
    public class MakeUserSeller {
        [Required]
        public int userId { get; set; }
        [Required]
        public bool flag { get; set; }
    }
    public class BanUser {
        [Required]
        public int userId { get; set; }
        [Required]
        public bool flag { get; set; }
    }
}
