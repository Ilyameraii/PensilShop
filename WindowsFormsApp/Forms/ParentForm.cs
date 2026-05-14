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

namespace PensilShop.Forms
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        protected void SetupForm(string title)
        {
            Text = $"Компания \"Пиши-стирай\" - {title}";
            titleLabel.Text = title;
            if (ContextManager.User != null)
            {
                fullNameLabel.Text = ContextManager.User.FullName;
                roleLabel.Text = "Роль: " + ContextManager.User.Role.Name;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
