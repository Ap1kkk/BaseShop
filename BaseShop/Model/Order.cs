using AutoPartsShop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Model
{
    [Serializable]
    public class Order
    {
        public int OrderId { get; set; }
        public User User { get; set; }
        public List<ProductOrder> Products { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public Order() { }

        public Order(int orderId, User user, List<ProductOrder> products, 
            DateTime orderDate, OrderStatus orderStatus)
        {
            OrderId = orderId;
            User = user;
            Products = products;
            OrderDate = orderDate;
            OrderStatus = orderStatus;
        }

        public double CalculateTotal()
        {
            return Products.Sum(product => product.Product.Price * product.Quantity);
        }
    }
}
