using AutoPartsShop.Model;
using AutoPartsShop.Controllers;
using AutoPartsShop.Utils;
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
    public partial class ShoppingCartForm : Form
    {
        private MainController _mainController;

        public ShoppingCartForm(MainController mainController)
        {
            InitializeComponent();
            _mainController = mainController;

            _mainController.ShoppingCartController.OnShoppingCartChanged += UpdateShoppingCart;

            UpdateShoppingCart();
        }

        ~ShoppingCartForm()
        {
            _mainController.ShoppingCartController.OnShoppingCartChanged -= UpdateShoppingCart;
        }

        private void UpdateShoppingCart()
        {
            var cartItems = _mainController.GetCartItems().ConvertAll(Converter.ConvertProductOrder);
            ShoppingCartDataGridView.DataSource = null;
            ShoppingCartDataGridView.DataSource = cartItems;
            ShoppingCartDataGridView.Update();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            _mainController.ClearCartItems();
            UpdateShoppingCart();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            var products = _mainController.GetCartItems();
            if(_mainController.PlaceOrder(products, out string message))
            {
                _mainController.ClearCartItems();
            }
            MessageBox.Show(message);
        }

    }
}
