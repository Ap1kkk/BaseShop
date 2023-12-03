using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNutritionShop.Model
{
    [Serializable]
    public class ShoppingCart
    {
        public User User { get; set; }
        public List<ProductOrder> Items { get; set; } = new List<ProductOrder>();

        public ShoppingCart() { }

        public ShoppingCart(User user)
        {
            User = user;
        }

        public void Clear()
        {
            Items = new List<ProductOrder>();
        }
    }
}
