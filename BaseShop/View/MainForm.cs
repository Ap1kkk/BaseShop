using SportsNutritionShop.Controllers;
using SportsNutritionShop.Model;
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
    public partial class MainForm : Form
    {
        private MainController _mainController;

        private UserProfileForm _userProfileForm;
        private ShoppingCartForm _shoppingCartForm;
        private CatalogForm _catalogForm;
        private OrdersForm _ordersForm;
        private PaymentHistoryForm _paymentHistoryForm;

        public MainForm(MainController mainController)
        {
            InitializeComponent();

            _mainController = mainController;

            _userProfileForm = new UserProfileForm(_mainController.UserService);
            _shoppingCartForm = new ShoppingCartForm(_mainController.ShoppingCartService, _mainController.OrderService);
            _catalogForm = new CatalogForm(_mainController.UserService, _mainController.ProductService, _mainController.ShoppingCartService);
            _ordersForm = new OrdersForm(_mainController.UserService, _mainController.OrderService, _mainController.PaymentService);
            _paymentHistoryForm = new PaymentHistoryForm(_mainController.UserService, _mainController.PaymentService);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = "Sport Nutrition Store";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainController.Save();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _userProfileForm.ShowDialog();
        }

        private void catalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _catalogForm.ShowDialog();
        }

        private void shoppingCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _shoppingCartForm.ShowDialog();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ordersForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _catalogForm.ShowDialog();
        }

        private void PaymentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _paymentHistoryForm.ShowDialog();
        }
    }
}
