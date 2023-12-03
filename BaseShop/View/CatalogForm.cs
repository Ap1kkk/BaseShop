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
    public partial class CatalogForm : Form
    {
        private List<Product> _products = new List<Product>();

        private Product _chosenProduct = null;

        private AddProductForm _addProductForm;

        private UserService _userService;
        private ProductService _productService;
        private ShoppingCartService _shoppingCartService;

        public CatalogForm(UserService userService, ProductService productService, ShoppingCartService shoppingCartService)
        {
            InitializeComponent();

            _shoppingCartService = shoppingCartService;

            _addProductForm = new AddProductForm(productService);

            _productService = productService;
            _productService.OnProductsChanged += UpdateCatalog;

            _userService = userService;
            _userService.OnUserChanged += _userService_OnUserChanged;
            _userService.OnUserLoggedOut += _userService_OnUserLoggedOut;

            catgalogDataGridView.RowEnter += CatgalogDataGridView_RowEnter;

            UpdateCatalog();
            UpdateAddProductButtonVisibility(false);
            UpdateAddToCartButton(false);
        }

        ~CatalogForm()
        {
            _productService.OnProductsChanged -= UpdateCatalog;
            _userService.OnUserChanged -= _userService_OnUserChanged;
            _userService.OnUserLoggedOut -= _userService_OnUserLoggedOut;
            catgalogDataGridView.RowEnter -= CatgalogDataGridView_RowEnter;
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

        private void _userService_OnUserLoggedOut()
        {
            UpdateAddProductButtonVisibility(false);
        }

        private void _userService_OnUserChanged(User user)
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
            _products = _productService.GetProducts();
            catgalogDataGridView.DataSource = null;
            catgalogDataGridView.DataSource = _products;
            catgalogDataGridView.Update();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            Text = "Product Catalog";
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _addProductForm.ShowDialog();
        }

        private void AddToShoppingCartButton_Click(object sender, EventArgs e)
        {
            var addProductToCartForm = new AddProductToCartForm(_shoppingCartService, _chosenProduct);
            addProductToCartForm.ShowDialog();
        }
    }
}
