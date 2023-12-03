using SportsNutritionShop.Model;
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
    public partial class UserProfileForm : Form
    {
        private UserService _userService;

        private LoginForm _loginForm;

        public UserProfileForm(UserService userService)
        {
            InitializeComponent();
            
            _loginForm = new LoginForm(userService);

            _userService = userService;
            _userService.OnUserChanged += UpdateUserProfile;
            _userService.OnUserLoggedOut += OnUserLoggedOut;

            OnUserLoggedOut();
        }

        private void OnUserLoggedOut()
        {
            UpdateShownButton();
            string username = "---";
            string email = "---";
            UpdateUserProfileLabels(username, email, false);
        }

        ~UserProfileForm()
        {
            _userService.OnUserChanged -= UpdateUserProfile;
        }

        private void UpdateShownButton()
        {
            if(_userService.CurrentUser != null) 
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
                UpdateUserProfileLabels(user.Username, user.Email, user.IsAdmin);
                UpdateShownButton();
            }
        }

        private void UpdateUserProfileLabels(string username,  string email, bool isAdmin)
        {
            lblUsername.Text = $"Имя пользователя: {username}";
            lblEmail.Text = $"Электронная почта: {email}";

            AdminLabel.Visible = isAdmin;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            _loginForm.ShowDialog();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            _userService.LogOutUser();
        }
    }
}
