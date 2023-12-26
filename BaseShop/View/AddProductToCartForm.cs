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
    public partial class AddProductToCartForm : Form
    {
        private MainController _mainController;

        private Product _selectedProduct;

        public AddProductToCartForm(MainController mainController, Product product)
        {
            InitializeComponent();
            _mainController = mainController;
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

            var result = _mainController.AddToCart(_selectedProduct, quantity, out string message);
            MessageBox.Show(message);

            if(result)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
