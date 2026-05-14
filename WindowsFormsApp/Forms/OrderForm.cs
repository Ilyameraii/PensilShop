using PensilShop.Services;
using PensilShop.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace PensilShop.Forms
{
    public partial class OrderForm : ParentForm
    {
        public OrderForm()
        {
            InitializeComponent();
            ContextManager.OrderForm=this;
            SetupForm("Заказы");
            CheckRole();
            FillOrders();
        }

        private void CheckRole()
        {
            if (ContextManager.User.IsAdmin())
            {
                addButton.Visible = true;
            }
        }

        public void FillOrders()
        {
            ordersFlowLayoutPanel.Controls.Clear();
            var orders = Program.Context.Orders.OrderByDescending(o => o.DeliveryDate).ToList();

            foreach (var order in orders)
            {
                ordersFlowLayoutPanel.Controls.Add(new OrderControl(order));
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (new EditOrderForm().ShowDialog() == DialogResult.OK)
            {
                FillOrders();
            }
        }
    }
}
