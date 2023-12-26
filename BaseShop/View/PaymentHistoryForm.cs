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
    public partial class PaymentHistoryForm : Form
    {
        private MainController _mainController;

        public PaymentHistoryForm(MainController mainController)
        {
            InitializeComponent();
            _mainController = mainController;

            _mainController.UserController.OnUserChanged += _userController_OnUserChanged;
            _mainController.UserController.OnUserLoggedOut += UpdateData;

            _mainController.PaymentController.OnPaymentChanged += UpdateData;
        }
        ~PaymentHistoryForm()
        {
            _mainController.UserController.OnUserChanged -= _userController_OnUserChanged;
            _mainController.UserController.OnUserLoggedOut -= UpdateData;

            _mainController.PaymentController.OnPaymentChanged -= UpdateData;
        }

        private void _userController_OnUserChanged(User user)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            dgvPaymentHistory.DataSource = null;
            dgvPaymentHistory.DataSource = _mainController.GetReceipts();
            dgvPaymentHistory.Update();
        }
    }
}
