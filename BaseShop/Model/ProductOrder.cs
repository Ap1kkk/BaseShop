using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Model
{
    [Serializable]
    public class ProductOrder
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public ProductOrder() { }

        public ProductOrder(Product product, int orderedQuantity)
        {
            Product = product;
            Quantity = orderedQuantity;
        }
    }
}
