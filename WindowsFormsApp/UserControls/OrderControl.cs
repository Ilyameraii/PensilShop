using PensilShop.Forms;
using PensilShop.Models;
using PensilShop.Services;
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

namespace PensilShop.UserControls
{
    public partial class OrderControl : UserControl
    {
        private bool CanClickUserControl = false;
        private readonly Order order;
        public OrderControl(Order order)
        {
            InitializeComponent();

            this.order = order;

            CheckRole();
            FillCard();
        }

        private void CheckRole()
        {
            if (ContextManager.User.IsAdmin())
            {
                deleteButton.Visible = true;
                CanClickUserControl = true;
            }

        }

        private void FillCard()
        {
            articulLabel.Text += order.Id.ToString();
            statusLabel.Text += order.Status.Name.ToString();
            addressLabel.Text += order.Office.Address;
            dateLabel.Text += order.Date.ToShortDateString();
            deliveryDatelabel.Text = order.DeliveryDate.ToShortDateString();
        }

        private void userControl_Click(object sender, EventArgs e)
        {
            if (CanClickUserControl)
            {
                if(new EditOrderForm(order).ShowDialog() == DialogResult.OK)
                {
                     ContextManager.OrderForm.FillOrders();
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Вы уверены что хотите удалить этот товар?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Program.Context.Orders.Remove(order);
                Program.Context.SaveChanges();
                ContextManager.OrderForm.FillOrders();
            }
        }
    }
}
