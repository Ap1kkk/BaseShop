using SportsNutritionShop.Model;
using SportsNutritionShop.Services.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsNutritionShop.Services
{
    public class PaymentService
    {
        public event Action OnPaymentChanged;

        private UserService _userService;
        private OrderService _orderService;
        private IPaymentDatabaseService _databaseService;

        private List<Receipt> _receipts;

        public PaymentService(UserService userService, OrderService orderService, IPaymentDatabaseService databaseService)
        {
            _userService = userService;

            _orderService = orderService;

            _databaseService = databaseService;
            _receipts = _databaseService.ReadReceipts();
        }

        public void Save()
        {
            _databaseService.WriteReceipts(_receipts);
        }

        public List<Receipt> GetReceipts()
        {
            List<Receipt> receipts = new List<Receipt>();
            if(_userService.CurrentUser != null)
            {
                receipts = _receipts.FindAll(c => c.User.Username ==  _userService.CurrentUser.Username);
            }
            return receipts;
        }

        public bool ProcessPayment(Order order, out string message)
        {
            if(_userService.CurrentUser == null)
            {
                message = "Войдите в аккаунт, чтобы оплатить заказ";
                return false;
            }

            if(!_orderService.MakeOrderPaid(order, out message))
            {
                return false;
            }
            var receipt = GenerateReceipt(order);
            LogPaymentHistory(receipt);
            OnPaymentChanged?.Invoke();
            message = $"Платеж для заказа {order.OrderId} успешно проведен.";
            return true;
        }

        private Receipt GenerateReceipt(Order order)
        {
            return new Receipt(order.OrderId, _userService.CurrentUser, DateTime.Now, order.CalculateTotal());
        }

        private void LogPaymentHistory(Receipt receipt)
        {
            _receipts.Add(receipt);
        }
    }

}
