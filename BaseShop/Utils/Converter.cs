﻿using SportsNutritionShop.Model;
using SportsNutritionShop.View.Model_View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNutritionShop.Utils
{
    public static class Converter
    {
        public static ProductOrderView ConvertProductOrder(ProductOrder product)
        {
            return new ProductOrderView(product);
        }
        public static List<ProductOrderView> ConvertProductOrders(List<ProductOrder> products)
        {
            return products.ConvertAll(new Converter<ProductOrder, ProductOrderView>(ConvertProductOrder));
        }
    }
}
