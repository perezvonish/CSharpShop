using CsharpShop.Domain.Enums;

namespace CsharpShop.Domain.Entities
{
    public class Product : BaseEntity
    { 
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int Discount { get; set; }
        public int QtyInStock { get; set; }
        public bool IsModerated { get; set; } = false;
        public ProductBanReasons? BanReason { get; set; } = null;
        public bool IsHidden { get; set; } = false;
        
        public Product(string title, string description, float price, int discount, int qtyInStock) { 
            this.Title = title;
            this.Description = description;
            this.Price = price;
            this.Discount = discount;
            this.QtyInStock = qtyInStock;
        }
    }
}
