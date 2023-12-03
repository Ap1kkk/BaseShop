using SportsNutritionShop.Services;
using SportsNutritionShop.Services.Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNutritionShop.Controllers
{
    public class MainController
    {
        public DatabaseService DatabaseService { get; private set; }
        public UserService UserService { get; private set; }
        public OrderService OrderService { get; private set; }
        public PaymentService PaymentService { get; private set; }
        public ProductService ProductService { get; private set; }
        public ShoppingCartService ShoppingCartService { get; private set; }

        public MainController() 
        {
            DatabaseService = new DatabaseService(ConfigurationManager.AppSettings.Get("DatabasePath"));
            UserService = new UserService(DatabaseService);
            ProductService = new ProductService(DatabaseService);
            OrderService = new OrderService(UserService, ProductService, DatabaseService);
            PaymentService = new PaymentService(UserService, OrderService, DatabaseService);
            ShoppingCartService = new ShoppingCartService(UserService, DatabaseService);
        }

        public void Save()
        {
            UserService.SaveUsers();

            OrderService.SaveOrders();
            PaymentService.Save();
            ProductService.SaveProducts();
            ShoppingCartService.SaveShoppingCarts();

            DatabaseService.Save();
        }
    }
}
