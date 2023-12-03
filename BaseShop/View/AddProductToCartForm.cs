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
    public partial class AddProductToCartForm : Form
    {
        private ShoppingCartService _shoppingCartService;
        private Product _selectedProduct;

        public AddProductToCartForm(ShoppingCartService shoppingCartService, Product product)
        {
            InitializeComponent();
            _shoppingCartService = shoppingCartService;
            _selectedProduct = product;

            ProductNameLabel.Text = product.Name;
            ProductNameLabel.ReadOnly = true;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(quantityUpDown.Text, out int quantity)
                || quantity <= 0
                || _selectedProduct.StockQuantity - quantity < 0)
            {
                MessageBox.Show("Пожалуйста, введите корректное количество.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = _shoppingCartService.AddToCart(_selectedProduct, quantity, out string message);
            MessageBox.Show(message);

            if(result)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
