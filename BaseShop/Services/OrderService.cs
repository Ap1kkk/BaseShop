using SportsNutritionShop.Model;
using SportsNutritionShop.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsNutritionShop.Services
{
    public class OrderService
    {
        public event Action OnOrdersChanged;

        private List<Order> _orders;

        private UserService _userService;
        private ProductService _productService;
        private IOrderDatabaseService _databaseService;

        public OrderService(UserService userService, ProductService productService, IOrderDatabaseService databaseService)
        {
            _userService = userService;
            _productService = productService;
            _databaseService = databaseService;
            _orders = databaseService.ReadOrders();
        }

        public void SaveOrders()
        {
            _databaseService.WriteOrders(_orders);
        }

        public bool MakeOrderPaid(Order order, out string message)
        {
            if(order.OrderStatus != OrderStatus.Pending && order.OrderStatus != OrderStatus.TemporaryInvalid)
            {
                message = $"Заказ {order.OrderId} не может быть оплачен: {order.OrderStatus}";
                return false;
            }

            bool isOrderValid = true;
            foreach (var item in order.Products)
            {
                isOrderValid = isOrderValid && _productService.IsProductCanBeOrdered(item.Product.ProductId, item.Quantity, out message);
            }

            if(!isOrderValid)
            {
                message = $"На данный момент заказ {order.OrderId} не может быть выполнен: {OrderStatus.TemporaryInvalid}";
                UpdateOrderStatus(order, OrderStatus.TemporaryInvalid);
                return false;
            }

            foreach (var item in order.Products)
            {
                isOrderValid = isOrderValid && _productService.OrderProduct(item.Product.ProductId, item.Quantity, out message);
            }

            UpdateOrderStatus(order, OrderStatus.Paid);
            message = $"Статус заказа {order.OrderId} обновлен: {OrderStatus.Paid}";
            return true;
        }

        private void UpdateOrderStatus(Order order, OrderStatus newStatus)
        {
            order.OrderStatus = newStatus;
            Console.WriteLine($"Статус заказа {order.OrderId} обновлен: {newStatus}");
            OnOrdersChanged?.Invoke();
        }

        public bool PlaceOrder(List<ProductOrder> products, out string message)
        {
            if(_userService.CurrentUser ==  null)
            {
                message = "Войдите, чтобы сделать заказ";
                return false;
            }

            Order newOrder = new Order(GenerateOrderId(), _userService.CurrentUser, products, DateTime.Now, OrderStatus.Pending);

            _orders.Add(newOrder);

            message = $"Заказ успешно размещен. Номер заказа: {newOrder.OrderId}";
            OnOrdersChanged?.Invoke();
            return true;
        }

        public List<Order> GetOrders()
        {
            List<Order> userOrders = new List<Order>();
            if(_userService.CurrentUser != null)
            {
                userOrders = _orders.FindAll(order => order.User.Username == _userService.CurrentUser.Username);
            }

            return userOrders;
        }

        private int GenerateOrderId()
        {
            Random random = new Random();
            return random.Next(1000, 9999);
        }
    }
}
