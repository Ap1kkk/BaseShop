using SportsNutritionShop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsNutritionShop.View
{
    public partial class RegisterForm : Form
    {
        private UserService _userService;
        public RegisterForm(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // Проверка введенных данных и выполнение регистрации
            bool isAdmin = IsAdminCheckBox.Checked;
            string username = usernameTextBox.Text;
            string email = EmailTextBox.Text;
            string adress = AdressTextBox.Text;
            string password = PasswordTextBox.Text;

            string message = string.Empty;

            if(_userService.RegisterUser(isAdmin, username, password, email, adress, out message))
            {
                MessageBox.Show(message);
                Close();
            }
            else
            {
                MessageBox.Show(message);
            }
        }
    }
}
