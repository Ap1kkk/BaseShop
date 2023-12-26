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
using System.Xml.Linq;

namespace AutoPartsShop.View
{
    public partial class AddProductForm : Form
    {
        private MainController _mainController;

        public AddProductForm(MainController mainController)
        {
            InitializeComponent();

            _mainController = mainController;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtYearOfManufacture.Text) ||
                string.IsNullOrWhiteSpace(txtManufacturer.Text) || string.IsNullOrWhiteSpace(txtSupplier.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) || string.IsNullOrWhiteSpace(txtStockQuantity.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtPrice.Text, out double price) ||
                !int.TryParse(txtStockQuantity.Text, out int stockQuantity))
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _mainController.AddProduct(new Product(txtName.Text, price, txtDescription.Text, txtSupplier.Text, txtManufacturer.Text, txtYearOfManufacture.Text, stockQuantity));

            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtStockQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStockQuantity_Click(object sender, EventArgs e)
        {

        }
    }
}
