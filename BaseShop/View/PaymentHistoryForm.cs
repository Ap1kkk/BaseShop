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
    public partial class PaymentHistoryForm : Form
    {

        private UserService _userService;
        private PaymentService _paymentService;

        public PaymentHistoryForm(UserService userService, PaymentService paymentService)
        {
            InitializeComponent();
            _userService = userService;
            _userService.OnUserChanged += _userService_OnUserChanged;
            _userService.OnUserLoggedOut += UpdateData;

            _paymentService = paymentService;
            _paymentService.OnPaymentChanged += UpdateData;
        }

        private void _userService_OnUserChanged(User user)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            dgvPaymentHistory.DataSource = null;
            dgvPaymentHistory.DataSource = _paymentService.GetReceipts();
            dgvPaymentHistory.Update();
        }
    }
}
