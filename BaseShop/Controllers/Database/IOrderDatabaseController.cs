using AutoPartsShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Controllers.Database
{
    public interface IOrderDatabaseController
    {
        List<Order> ReadOrders();

        void WriteOrders(List<Order> orders);
    }
}
