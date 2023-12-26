using AutoPartsShop.Model;
using AutoPartsShop.Controllers.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPartsShop.Controllers
{
    public class PaymentController
    {
        public event Action OnPaymentChanged;

        private UserController _userController;
        private OrderController _orderController;
        private IPaymentDatabaseController _databaseController;

        private List<Receipt> _receipts;

        public PaymentController(UserController userController, OrderController orderController, IPaymentDatabaseController databaseController)
        {
            _userController = userController;

            _orderController = orderController;

            _databaseController = databaseController;
            _receipts = _databaseController.ReadReceipts();
        }

        public void Save()
        {
            _databaseController.WriteReceipts(_receipts);
        }

        public List<Receipt> GetReceipts()
        {
            List<Receipt> receipts = new List<Receipt>();
            if(_userController.CurrentUser != null)
            {
                receipts = _receipts.FindAll(c => c.User.Username ==  _userController.CurrentUser.Username);
            }
            return receipts;
        }

        public bool ProcessPayment(Order order, out string message)
        {
            if(_userController.CurrentUser == null)
            {
                message = "Войдите в аккаунт, чтобы оплатить заказ";
                return false;
            }

            if(!_orderController.MakeOrderPaid(order, out message))
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
            return new Receipt(order.OrderId, _userController.CurrentUser, DateTime.Now, order.CalculateTotal());
        }

        private void LogPaymentHistory(Receipt receipt)
        {
            _receipts.Add(receipt);
        }
    }

}
