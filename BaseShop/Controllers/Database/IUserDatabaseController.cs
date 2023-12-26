using AutoPartsShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Controllers.Database
{
    public interface IUserDatabaseController
    {
        List<User> ReadUsers();
        void WriteUsers(List<User> users);
    }
}
