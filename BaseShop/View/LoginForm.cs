using AutoPartsShop.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPartsShop.View
{
    public partial class LoginForm : Form
    {
        private MainController _mainController;

        public LoginForm(MainController mainController)
        {
            InitializeComponent();

            _mainController = mainController;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            string message = string.Empty;

            if (_mainController.LogInUser(username, password, out message))
            {
                MessageBox.Show(message);
                Close();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registrationForm = new RegisterForm(_mainController);
            registrationForm.ShowDialog();
        }
    }
}
