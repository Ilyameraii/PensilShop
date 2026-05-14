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

namespace PensilShop.Forms
{
    public partial class EditOrderForm : ParentForm
    {
        private Order order;
        public EditOrderForm(Order order = null)
        {
            InitializeComponent();

            SetupForm("Добавление/редактирование заказа");
            if (order != null)
            {
                this.order = order;
            }
            else
            {
                this.order = new Order
                {
                    Id = 0,
                    Date = DateTime.Now,
                    DeliveryDate = DateTime.Now,
                    ReceiveCode=100,
                };
            }
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pensil_shopDataSet);

        }

        private void EditOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pensil_shopDataSet.Status". При необходимости она может быть перемещена или удалена.
            this.statusTableAdapter.Fill(this.pensil_shopDataSet.Status);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pensil_shopDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.pensil_shopDataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pensil_shopDataSet.Office". При необходимости она может быть перемещена или удалена.
            this.officeTableAdapter.Fill(this.pensil_shopDataSet.Office);
            FillForm();
        }

        private void FillForm()
        {
            dateDateTimePicker.Value = order.Date;
            deliveryDateDateTimePicker.Value = order.DeliveryDate;
            officeComboBox.SelectedValue = order.OfficeId;
            userComboBox.SelectedValue= order.UserId;
            emailTextBox.Text = order.Email;
            receiveCodeNumericUpDown.Value = order.ReceiveCode;
            statusComboBox.SelectedValue=order.StatusId;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }
            FillOrder();
            if (order.Id == 0)
            {
                Program.Context.Orders.Add(order);
            }
            Program.Context.SaveChanges();

            DialogResult = DialogResult.OK;
        }

        private void FillOrder()
        {
            order.Date = dateDateTimePicker.Value;
            order.DeliveryDate = deliveryDateDateTimePicker.Value;
            order.OfficeId = (int)officeComboBox.SelectedValue;
            order.UserId = (int)userComboBox.SelectedValue;
            order.Email = emailTextBox.Text;
            order.ReceiveCode = (int)receiveCodeNumericUpDown.Value;
            order.StatusId = (int)statusComboBox.SelectedValue;
        }

        private void General_Validating(object sender, CancelEventArgs e)
        {
            ValidationService.General_Validating(sender, e);
        }

        private void dateDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            var control = sender as Control;

            if (dateDateTimePicker.Value > deliveryDateDateTimePicker.Value)
            {
                errorProvider1.SetError(control, "Дата заказа не может быть позже даты доставки");
            }
            else
            {
                errorProvider1.SetError(control, string.Empty);
            }
        }
    }
}
