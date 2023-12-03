using SportsNutritionShop.Model;
using SportsNutritionShop.Services;
using SportsNutritionShop.Utils;
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
    public partial class ShoppingCartForm : Form
    {
        private ShoppingCartService _shoppingCartService;
        private OrderService _orderService;

        public ShoppingCartForm(ShoppingCartService shoppingCartService, OrderService orderService)
        {
            InitializeComponent();
            _shoppingCartService = shoppingCartService;
            _orderService = orderService;

            _shoppingCartService.OnShoppingCartChanged += UpdateShoppingCart;

            UpdateShoppingCart();
        }

        ~ShoppingCartForm()
        {
            _shoppingCartService.OnShoppingCartChanged -= UpdateShoppingCart;
        }

        private void UpdateShoppingCart()
        {
            var cartItems = _shoppingCartService.GetCartItems().ConvertAll(Converter.ConvertProductOrder);
            ShoppingCartDataGridView.DataSource = null;
            ShoppingCartDataGridView.DataSource = cartItems;
            ShoppingCartDataGridView.Update();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            _shoppingCartService.ClearCartItems();
            UpdateShoppingCart();
        }

        private void ShoppingCartForm_Load(object sender, EventArgs e)
        {
            Text = "Shopping Cart";
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            var products = _shoppingCartService.GetCartItems();
            if(_orderService.PlaceOrder(products, out string message))
            {
                _shoppingCartService.ClearCartItems();
            }
            MessageBox.Show(message);
        }

    }
}
