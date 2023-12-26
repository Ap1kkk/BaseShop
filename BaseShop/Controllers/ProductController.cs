using AutoPartsShop.Model;
using AutoPartsShop.Controllers.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Controllers
{
    public class ProductController
    {
        public event Action OnProductsChanged;

        private List<Product> _products;
        private IProductDatabaseController _databaseController;

        public ProductController(IProductDatabaseController databaseController)
        {
            _databaseController = databaseController;
            _products = _databaseController.ReadProducts();
        }

        public void SaveProducts()
        {
            _databaseController.WriteProducts(_products);
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public Product GetProductById(int productId)
        {
            return _products.Find(product => product.ProductId == productId);
        }

        public void AddProduct(Product product)
        {
            product.ProductId = GetNextProductId();
            _products.Add(product);
            OnProductsChanged?.Invoke();
        }

        public bool OrderProduct(int productId, int quantity, out string message)
        {
            if(!IsProductCanBeOrdered(productId, quantity, out message))
                return false;

            var product = GetProductById(productId);

            product.StockQuantity -= quantity;
            OnProductsChanged?.Invoke();
            message = $"Продукт {productId} в количестве {quantity} зарезервирован";
            return true;
        }

        public bool IsProductCanBeOrdered(int productId, int quantity, out string message)
        {
            var product = GetProductById(productId);

            if (product == null)
            {
                message = $"Неверные данные продукта {productId}";
                return false;
            }
            if (quantity <= 0)
            {
                message = $"Неверное количество продукта {quantity}";
                return false;
            }

            if (product.StockQuantity - quantity < 0)
            {
                message = $"Недостаточное количество продукта {productId} в магазине";
                return false;
            }

            message = $"Продукт {productId} в количестве {quantity} может быть выкуплен";
            return true;
        }

        private int GetNextProductId()
        {
            return _products.Count + 1;
        }
    }
}
