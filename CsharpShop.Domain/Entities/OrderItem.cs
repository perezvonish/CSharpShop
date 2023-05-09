using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public Order Order { get; set; } = null!;
        public float Price { get; set; }
        public int Qty { get; set; }


        public OrderItem(Order order, float price, int qty) { 
            this.Order = order;
            this.Price = price;
            this.Qty = qty;
        }
    }
}
