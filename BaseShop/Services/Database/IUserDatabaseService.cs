using SportsNutritionShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNutritionShop.Services.Database
{
    public interface IUserDatabaseService
    {
        List<User> ReadUsers();
        void WriteUsers(List<User> users);
    }
}
