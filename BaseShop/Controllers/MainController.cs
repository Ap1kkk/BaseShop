using AutoPartsShop.Controllers;
using AutoPartsShop.Controllers.Database;
using AutoPartsShop.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Controllers
{
    public class MainController
    {
        public DatabaseСontroller DatabaseController { get; private set; }
        public UserController UserController { get; private set; }
        public OrderController OrderController { get; private set; }
        public PaymentController PaymentController { get; private set; }
        public ProductController ProductController { get; private set; }
        public ShoppingCartController ShoppingCartController { get; private set; }

        public MainController() 
        {
            DatabaseController = new DatabaseСontroller(ConfigurationManager.AppSettings.Get("DatabasePath"));
            UserController = new UserController(DatabaseController);
            ProductController = new ProductController(DatabaseController);
            OrderController = new OrderController(UserController, ProductController, DatabaseController);
            PaymentController = new PaymentController(UserController, OrderController, DatabaseController);
            ShoppingCartController = new ShoppingCartController(UserController, DatabaseController);
        }

        public void Save()
        {
            UserController.SaveUsers();

            OrderController.SaveOrders();
            PaymentController.Save();
            ProductController.SaveProducts();
            ShoppingCartController.SaveShoppingCarts();

            DatabaseController.Save();
        }

        public bool PlaceOrder(List<ProductOrder> products, out string message)
        {
            return OrderController.PlaceOrder(products, out message);
        }

        public List<Order> GetOrders()
        {
            return OrderController.GetOrders();
        }

        public List<Receipt> GetReceipts()
        {
            return PaymentController.GetReceipts();
        }
        public bool ProcessPayment(Order order, out string message)
        {
            return PaymentController.ProcessPayment(order, out message);
        }

        public List<Product> GetProducts()
        {
            return ProductController.GetProducts();
        }
        public void AddProduct(Product product)
        {
            ProductController.AddProduct(product);
        }

        public List<ProductOrder> GetCartItems()
        {
            return ShoppingCartController.GetCartItems();
        }
        public void ClearCartItems()
        {
            ShoppingCartController.ClearCartItems();
        }
        public bool AddToCart(Product product, int quantity, out string message)
        {
            return ShoppingCartController.AddToCart(product, quantity, out message);
        }

        public bool RegisterUser(bool isAdmin, string username, string password, string email, string adress, out string message)
        {
            return UserController.RegisterUser(isAdmin, username, password, email, adress, out message);
        }
        public bool LogInUser(string username, string password, out string message)
        {
            return UserController.LogInUser(username, password, out message);
        }
        public void LogOutUser()
        {
            UserController.LogOutUser();
        }
    }
}
