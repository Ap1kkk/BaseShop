using AutoPartsShop.Model;
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
    public partial class UserProfileForm : Form
    {
        private MainController _mainController;

        private LoginForm _loginForm;

        public UserProfileForm(MainController mainController)
        {
            InitializeComponent();

            _loginForm = new LoginForm(mainController);

            _mainController = mainController;
            _mainController.UserController.OnUserChanged += UpdateUserProfile;
            _mainController.UserController.OnUserLoggedOut += OnUserLoggedOut;

            OnUserLoggedOut();
        }
        ~UserProfileForm()
        {
            _mainController.UserController.OnUserChanged -= UpdateUserProfile;
            _mainController.UserController.OnUserLoggedOut -= OnUserLoggedOut;
        }

        private void OnUserLoggedOut()
        {
            UpdateShownButton();
            string username = "---";
            string email = "---";
            string adress = "---";
            UpdateUserProfileLabels(username, email, adress, false);
        }

        private void UpdateShownButton()
        {
            if(_mainController.UserController.CurrentUser != null) 
            { 
                LoginButton.Visible = false;
                LogoutButton.Visible = true;
            }
            else
            {
                LoginButton.Visible = true;
                LogoutButton.Visible = false;
            }
        }

        private void UpdateUserProfile(User user)
        {
            if(user != null)
            {
                UpdateUserProfileLabels(user.Username, user.Email, user.Adress, user.IsAdmin);
                UpdateShownButton();
            }
        }

        private void UpdateUserProfileLabels(string username,  string email, string adress, bool isAdmin)
        {
            lblUsername.Text = $"Имя пользователя: {username}";
            lblEmail.Text = $"Электронная почта: {email}";
            lblAdress.Text = $"Адрес: {adress}";

            AdminLabel.Visible = isAdmin;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            _loginForm.ShowDialog();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            _mainController.LogOutUser();
        }
    }
}
