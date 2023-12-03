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

        private UserService _userService;
        private OrderService _orderService;
        private PaymentService _paymentService;

        private List<Order> _orders = new List<Order>();
        private Order _selectedOrder;

        public OrdersForm(UserService userService, OrderService orderService, PaymentService paymentService)
        {
            InitializeComponent();
            _userService = userService;
            _userService.OnUserChanged += _userService_OnUserChanged;
            _userService.OnUserLoggedOut += UpdateOrders;

            _orderService = orderService;
            _orderService.OnOrdersChanged += UpdateOrders;

            _paymentService = paymentService;

            OrdersDataGridView.RowEnter += OrdersDataGridView_RowEnter;

            UpdateButtonsEnabled(false);

            UpdateOrders();
        }

        private void _userService_OnUserChanged(User user)
        {
            UpdateOrders();
        }

        ~OrdersForm()
        {
            _orderService.OnOrdersChanged -= UpdateOrders;
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
            _orders = _orderService.GetOrders();

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
        
        private void OrdersForm_Load(object sender, EventArgs e)
        {
            Text = "Orders";
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            _paymentService.ProcessPayment(_selectedOrder, out string message);
            MessageBox.Show(message);
        }
    }
}
