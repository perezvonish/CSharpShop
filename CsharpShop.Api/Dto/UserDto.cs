using CsharpShop.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CsharpShop.Api.Dto
{
    public class UserBan
    {
        [Required]
        public int Id { get; set; } = 0;

        [Required]
        public bool Flag { get; set; }

        [AllowNull]
        public UserBanReasons? UserBanReason { get; set; } = null;
    }
}
