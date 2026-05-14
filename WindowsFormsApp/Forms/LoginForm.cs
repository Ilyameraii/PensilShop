using PensilShop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace PensilShop.Forms
{
    public partial class LoginForm : ParentForm
    {
        public LoginForm()
        {
            InitializeComponent();
            SetupForm("Авторизация");
        }

        public void Authorization(string login, string password)
        {
            var user = Program.Context.Users.Where(u=>u.Login == login).FirstOrDefault(u=>u.Password==password);

            if (user != null)
            {
                ContextManager.User = user;
                Hide();
                new ProductForm().ShowDialog();
                ContextManager.User = null;
                Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            Authorization("g","g");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Authorization(loginTextBox.Text, passwordTextBox.Text);
        }
    }
}
