using PensilShop.Models;
using PensilShop.Services;
using PensilShop.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace PensilShop.Forms
{
    public partial class ProductForm : ParentForm
    {
        public ProductForm()
        {
            InitializeComponent();
            ContextManager.ProductForm = this;
            SetupForm("Товары");
            SetupComboboxes();
            CheckRole();
        }

        private void CheckRole()
        {
            if (ContextManager.User.IsAdmin())
            {
                managerPanel.Visible = true;
                addButton.Visible = true;
            }
            if (ContextManager.User.IsManager())
            {
                managerPanel.Visible = true;
            }
        }

        private void SetupComboboxes()
        {
            var categories = Program.Context.Categories.Prepend(new Category { Id = 0, Name = "Все" }).ToList();
            categoryComboBox.DataSource = categories;
            categoryComboBox.DisplayMember = nameof(Category.Name);
            categoryComboBox.ValueMember = nameof(Category.Id);

            sortComboBox.SelectedIndex = 0;
        }

        public Task FillProducts()
        {
            productsFlowLayoutPanel.Controls.Clear();

            var products = FilteredProducts();

            foreach (var product in products)
            {
                productsFlowLayoutPanel.Controls.Add(new ProductControl(product));
            }

            return Task.CompletedTask;
        }

        private List<Product> FilteredProducts()
        {
            var products = Program.Context.Products.AsQueryable();

            // поиск
            if (!string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                products = products.Where(p =>
                p.ProductName.Name.ToLower().Contains(searchTextBox.Text.ToLower()) ||
                p.Articul.ToLower().Contains(searchTextBox.Text.ToLower()) ||
                p.Description.ToLower().Contains(searchTextBox.Text.ToLower()) ||
                p.Manufacturer.Name.ToLower().Contains(searchTextBox.Text.ToLower()) ||
                p.Supplier.Name.ToLower().Contains(searchTextBox.Text.ToLower()) ||
                p.Category.Name.ToLower().Contains(searchTextBox.Text.ToLower())
                    );
            }

            // фильтрация
            if (categoryComboBox.SelectedValue is int && (int)categoryComboBox.SelectedValue > 0)
            {
                products = products.Where(p => p.CategoryId == (int)categoryComboBox.SelectedValue);
            }

            // сортировка
            if (sortComboBox.SelectedIndex == 0)
            {
                products = products.OrderBy(p => p.Price);
            }
            else
            {
                products = products.OrderByDescending(p => p.Price);
            }
            return products.ToList();
        }

        private async void ProductForm_Load(object sender, EventArgs e)
        {
            await FillProducts();
        }

        private async void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            await FillProducts();
        }

        private async void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await FillProducts();
        }

        private async void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await FillProducts();
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            if(new EditProductForm().ShowDialog() == DialogResult.OK)
            {
                await FillProducts();
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            new OrderForm().ShowDialog();
        }
    }
}
