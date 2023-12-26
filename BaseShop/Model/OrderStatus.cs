using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Model
{
    public enum OrderStatus
    {
        TemporaryInvalid,
        Pending,
        Paid,
        Shipped,
        Delivered,
    }
}
