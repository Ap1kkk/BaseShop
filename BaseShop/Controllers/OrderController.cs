using AutoPartsShop.Model;
using AutoPartsShop.Controllers.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPartsShop.Controllers
{
    public class OrderController
    {
        public event Action OnOrdersChanged;

        private List<Order> _orders;

        private UserController _userController;
        private ProductController _productController;
        private IOrderDatabaseController _databaseController;

        public OrderController(UserController userController, ProductController productController, IOrderDatabaseController databaseController)
        {
            _userController = userController;
            _productController = productController;
            _databaseController = databaseController;
            _orders = databaseController.ReadOrders();
        }

        public void SaveOrders()
        {
            _databaseController.WriteOrders(_orders);
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
                isOrderValid = isOrderValid && _productController.IsProductCanBeOrdered(item.Product.ProductId, item.Quantity, out message);
            }

            if(!isOrderValid)
            {
                message = $"На данный момент заказ {order.OrderId} не может быть выполнен: {OrderStatus.TemporaryInvalid}";
                UpdateOrderStatus(order, OrderStatus.TemporaryInvalid);
                return false;
            }

            foreach (var item in order.Products)
            {
                isOrderValid = isOrderValid && _productController.OrderProduct(item.Product.ProductId, item.Quantity, out message);
            }

            UpdateOrderStatus(order, OrderStatus.Paid);
            message = $"Статус заказа {order.OrderId} обновлен: {OrderStatus.Paid}";
            return true;
        }

        public bool PlaceOrder(List<ProductOrder> products, out string message)
        {
            if(_userController.CurrentUser ==  null)
            {
                message = "Войдите, чтобы сделать заказ";
                return false;
            }

            Order newOrder = new Order(GenerateOrderId(), _userController.CurrentUser, products, DateTime.Now, OrderStatus.Pending);

            _orders.Add(newOrder);

            message = $"Заказ успешно размещен. Номер заказа: {newOrder.OrderId}";
            OnOrdersChanged?.Invoke();
            return true;
        }

        public List<Order> GetOrders()
        {
            List<Order> userOrders = new List<Order>();
            if(_userController.CurrentUser != null)
            {
                userOrders = _orders.FindAll(order => order.User.Username == _userController.CurrentUser.Username);
            }

            return userOrders;
        }

        private int GenerateOrderId()
        {
            Random random = new Random();
            return random.Next(1000, 9999);
        }

        private void UpdateOrderStatus(Order order, OrderStatus newStatus)
        {
            order.OrderStatus = newStatus;
            Console.WriteLine($"Статус заказа {order.OrderId} обновлен: {newStatus}");
            OnOrdersChanged?.Invoke();
        }
    }
}
