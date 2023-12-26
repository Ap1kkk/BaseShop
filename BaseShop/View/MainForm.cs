using AutoPartsShop.Controllers;
using AutoPartsShop.Model;
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

            _userProfileForm = new UserProfileForm(_mainController);
            _shoppingCartForm = new ShoppingCartForm(_mainController);
            _catalogForm = new CatalogForm(_mainController);
            _ordersForm = new OrdersForm(_mainController);
            _paymentHistoryForm = new PaymentHistoryForm(_mainController);
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
