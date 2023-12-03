using SportsNutritionShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNutritionShop.Services.Database
{
    public interface IPaymentDatabaseService
    {
        List<Receipt> ReadReceipts();
        void WriteReceipts(List<Receipt> receipts);
    }
}
