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
    public partial class RegisterForm : Form
    {
        private MainController _mainController;

        public RegisterForm(MainController mainController)
        {
            InitializeComponent();

            _mainController = mainController;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            bool isAdmin = IsAdminCheckBox.Checked;
            string username = usernameTextBox.Text;
            string email = EmailTextBox.Text;
            string adress = AdressTextBox.Text;
            string password = PasswordTextBox.Text;

            string message = string.Empty;

            if(_mainController.RegisterUser(isAdmin, username, password, email, adress, out message))
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
