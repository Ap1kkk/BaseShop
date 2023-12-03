using SportsNutritionShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNutritionShop.View.Model_View
{
    public struct ProductOrderView
    {
        public int ProductId => _product.Product.ProductId;
        public string Name => _product.Product.Name;
        public string Description => _product.Product.Description;
        public double Price => _product.Product.Price;
        public int Quantity => _product.Quantity;

        private ProductOrder _product;
        public ProductOrderView(ProductOrder shoppingCartItem)
        {
            _product = shoppingCartItem;
        }
    }
}
