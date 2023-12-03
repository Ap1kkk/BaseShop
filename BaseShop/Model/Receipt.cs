using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNutritionShop.Model
{
    [Serializable]
    public class Receipt
    {
        public int OrderId { get; set; }
        public User User { get; set; }
        public DateTime ReceiptDate { get; set; }
        public double TotalAmount { get; set; }

        public Receipt() { }

        public Receipt(int orderId, User user, DateTime receiptDate, double totalAmount)
        {
            OrderId = orderId;
            User = user;
            ReceiptDate = receiptDate;
            TotalAmount = totalAmount;
        }
    }
}
