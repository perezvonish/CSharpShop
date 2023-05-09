using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop.Domain.Entities
{
    public class Order : BaseEntity
    {
        public User User { get; set; }
        public ICollection<OrderItem> OrderItems { get; set;}
        public float Price { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Phonenumber { get; set; }

        public Order(User user, ICollection<OrderItem> OrderItems, float price, string country, string region, string address, string city, string postalCode, string phonenumber) { 
            this.User = user;
            this.OrderItems = OrderItems;
            this.Price = price;
            this.Country = country;
            this.Region = region;
            this.Address = address;
            this.City = city;
            this.PostalCode = postalCode;
            this.Phonenumber = phonenumber;
        }
    }
}
