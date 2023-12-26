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
    public partial class CatalogForm : Form
    {
        private List<Product> _products = new List<Product>();

        private Product _chosenProduct = null;

        private AddProductForm _addProductForm;

        private MainController _mainController;

        public CatalogForm(MainController mainController)
        {
            InitializeComponent();

            _addProductForm = new AddProductForm(mainController);

            _mainController = mainController;
            _mainController.ProductController.OnProductsChanged += UpdateCatalog;

            _mainController.UserController.OnUserChanged += _userController_OnUserChanged;
            _mainController.UserController.OnUserLoggedOut += _userController_OnUserLoggedOut;

            catalogDataGridView.RowEnter += CatgalogDataGridView_RowEnter;

            UpdateCatalog();
            UpdateAddProductButtonVisibility(false);
            UpdateAddToCartButton(false);
        }

        ~CatalogForm()
        {
            _mainController.ProductController.OnProductsChanged -= UpdateCatalog;
            _mainController.UserController.OnUserChanged -= _userController_OnUserChanged;
            _mainController.UserController.OnUserLoggedOut -= _userController_OnUserLoggedOut;
            catalogDataGridView.RowEnter -= CatgalogDataGridView_RowEnter;
        }

        private void CatgalogDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _chosenProduct = _products.ElementAt(e.RowIndex);
            if (_chosenProduct != null)
            {
                if (_chosenProduct.StockQuantity > 0)
                {
                    UpdateAddToCartButton(true);
                }
            }
        }

        private void _userController_OnUserLoggedOut()
        {
            UpdateAddProductButtonVisibility(false);
        }

        private void _userController_OnUserChanged(User user)
        {
            UpdateAddProductButtonVisibility(user.IsAdmin);
        }

        private void UpdateAddProductButtonVisibility(bool isVisible)
        {
            AddProductToolStripMenuItem.Visible = isVisible;
        }

        private void UpdateAddToCartButton(bool isEnabled)
        {
            AddToShoppingCartButton.Enabled = isEnabled;
        }

        private void UpdateCatalog()
        {
            _products = _mainController.GetProducts();
            catalogDataGridView.DataSource = null;
            catalogDataGridView.DataSource = _products;
            catalogDataGridView.Update();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _addProductForm.ShowDialog();
        }

        private void AddToShoppingCartButton_Click(object sender, EventArgs e)
        {
            var addProductToCartForm = new AddProductToCartForm(_mainController, _chosenProduct);
            addProductToCartForm.ShowDialog();
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterCatalog();
        }

        private void FilterCatalog()
        {
            string filterText = filterTextBox.Text.ToLower();

            List<Product> filteredProducts = _products
                .Where(product =>
                    product.Name.ToLower().Contains(filterText) ||
                    product.Description.ToLower().Contains(filterText) ||
                    product.Price.ToString().Contains(filterText))
                .ToList();

            catalogDataGridView.DataSource = null;
            catalogDataGridView.DataSource = filteredProducts;
            catalogDataGridView.Update();
        }
    }
}
