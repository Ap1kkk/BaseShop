using AutoPartsShop.Model;
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
    public partial class OrderDetailsForm : Form
    {
        private Order _order;

        public OrderDetailsForm(Order order)
        {
            InitializeComponent();
            _order = order;
            UpdateOrderDetails();
        }

        private void UpdateOrderDetails()
        {
            orderIdLabel.Text = $"Order ID: {_order.OrderId}";
            orderDateLabel.Text = $"Order Date: {_order.OrderDate}";

            orderItemsDataGridView.DataSource = null;
            orderItemsDataGridView.DataSource = Converter.ConvertProductOrders(_order.Products);
            orderItemsDataGridView.Update();
        }
    }
}
