using AutoPartsShop.Model;
using AutoPartsShop.Controllers.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Controllers
{
    public class UserController
    {
        public static User DefaultUser => new User() { Username = "DEFAULT", Password = "DEFAULT", Adress = "DEFAULT", Email = "DEFAULT" };

        public event Action<User> OnUserChanged;
        public event Action OnUserLoggedOut;

        public User CurrentUser { get; private set; }
        public bool IsLoggedIn => CurrentUser != null;

        private List<User> _registeredUsers;
        private IUserDatabaseController _databaseController;

        public UserController(IUserDatabaseController databaseController)
        {
            _databaseController = databaseController;
            _registeredUsers = _databaseController.ReadUsers();
        }

        public void SaveUsers()
        {
            _databaseController.WriteUsers(_registeredUsers);
        }

        public bool RegisterUser(bool isAdmin, string username, string password, string email, string adress, out string message)
        {
            if (UserExists(username))
            {
                message = "Пользователь с таким именем уже существует.";
                return false;
            }

            User newUser = new User(isAdmin, username, password, email, adress);
            _registeredUsers.Add(newUser);

            message = "Регистрация успешна.";
            return true;
        }

        public bool LogInUser(string username, string password, out string message)
        {
            User user = _registeredUsers.Find(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                CurrentUser = user;
                OnUserChanged?.Invoke(CurrentUser);
                message = "Авторизация успешна.";
                return true;
            }
            else
            {
                message = "Неверные учетные данные. Попробуйте снова.";
                return false;
            }
        }

        public void LogOutUser()
        {
            CurrentUser = null;
            OnUserLoggedOut?.Invoke();
        }

        private bool UserExists(string username)
        {
            return _registeredUsers.Exists(u => u.Username == username);
        }
    }
}
