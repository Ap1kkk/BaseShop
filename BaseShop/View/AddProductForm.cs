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
using System.Xml.Linq;

namespace SportsNutritionShop.View
{
    public partial class AddProductForm : Form
    {
        private ProductService _productService;

        public AddProductForm(ProductService productService)
        {
            InitializeComponent();
            _productService = productService;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Проверка наличия введенных данных
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) || string.IsNullOrWhiteSpace(txtStockQuantity.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Попытка парсинга числовых значений
            if (!double.TryParse(txtPrice.Text, out double price) ||
                !int.TryParse(txtStockQuantity.Text, out int stockQuantity))
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _productService.AddProduct(new Product(txtName.Text, price, txtDescription.Text, stockQuantity));

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
