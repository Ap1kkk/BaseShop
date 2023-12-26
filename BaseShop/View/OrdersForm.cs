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
    public partial class OrdersForm : Form
    {
        private struct OrderView
        {
            public int OrderId => _relatedOrder.OrderId;
            public DateTime OrderDate => _relatedOrder.OrderDate;
            public OrderStatus OrderStatus => _relatedOrder.OrderStatus;

            private Order _relatedOrder;

            public OrderView(Order order)
            {
                _relatedOrder = order;
            }
        }

        private MainController _mainController;

        private List<Order> _orders = new List<Order>();
        private Order _selectedOrder;

        public OrdersForm(MainController mainController)
        {
            InitializeComponent();

            _mainController = mainController;

            _mainController.UserController.OnUserChanged += _userController_OnUserChanged;
            _mainController.UserController.OnUserLoggedOut += UpdateOrders;

            _mainController.OrderController.OnOrdersChanged += UpdateOrders;

            OrdersDataGridView.RowEnter += OrdersDataGridView_RowEnter;

            UpdateButtonsEnabled(false);

            UpdateOrders();
        }

        private void _userController_OnUserChanged(User user)
        {
            UpdateOrders();
        }

        ~OrdersForm()
        {
            _mainController.UserController.OnUserChanged -= _userController_OnUserChanged;
            _mainController.UserController.OnUserLoggedOut -= UpdateOrders;

            _mainController.OrderController.OnOrdersChanged -= UpdateOrders;

            OrdersDataGridView.RowEnter -= OrdersDataGridView_RowEnter;
        }

        private void OrdersDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _selectedOrder = _orders.ElementAt(e.RowIndex);
            if (_selectedOrder != null)
            {
                UpdateButtonsEnabled(true);
            }
        }

        private void UpdateButtonsEnabled(bool isEnabled)
        {
            viewDetailsButton.Enabled = isEnabled;
            PayButton.Enabled = isEnabled;
        }

        private void UpdateOrders()
        {
            _orders = _mainController.GetOrders();

            OrdersDataGridView.DataSource = null;
            OrdersDataGridView.DataSource = _orders.ConvertAll(new Converter<Order, OrderView>(ConvertOrderToView));
            OrdersDataGridView.Update();
        }

        private OrderView ConvertOrderToView(Order order)
        {
            return new OrderView(order);
        }

        private void viewDetailsButton_Click(object sender, EventArgs e)
        {
            OrderDetailsForm orderDetailsForm = new OrderDetailsForm(_selectedOrder);
            orderDetailsForm.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            _mainController.ProcessPayment(_selectedOrder, out string message);
            MessageBox.Show(message);
        }
    }
}
