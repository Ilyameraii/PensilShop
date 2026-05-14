using PensilShop.Forms;
using PensilShop.Models;
using PensilShop.Properties;
using PensilShop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace PensilShop.UserControls
{
    public partial class ProductControl : UserControl
    {
        private readonly Product product;
        private bool CanClickUserControl = false;
        public ProductControl(Product product)
        {
            InitializeComponent();
            this.product = product;
            FillCard();
            CheckRole();
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
            categoryLabel.Text = product.Category.Name;
            nameLabel.Text = product.ProductName.Name;
            descriptionLabel.Text += $" {product.Description}";
            manufacturerLabel.Text += $" {product.Manufacturer.Name}";
            supplierLabel.Text += $" {product.Supplier.Name}";
            SetPrice();
            unitOfMeasurementLabel.Text += $" {product.UnitOfMeasurement.Name}";
            SetStock();
            SetDiscount();
            SetPhoto();

        }

        private void SetPhoto()
        {
            try
            {
                photoPictureBox.Image = new Bitmap(
                    Image.FromFile(
                        Path.Combine(
                            Application.StartupPath, "img", product.Photo)
                        ), new Size(300, 200)
                    );
            }
            catch
            {
                photoPictureBox.Image = Resources.picture;
            }
        }

        private void SetStock()
        {
            stockLabel.Text += $" {product.Stock}";
            if (product.Stock == 0)
            {
                BackColor = ColorTranslator.FromHtml("#f2b55c");
            }
        }

        private void SetDiscount()
        {
            discountLabel.Text = product.Discount.ToString();
            if (product.Discount > 7)
            {
                BackColor = ColorTranslator.FromHtml("#f1fcb2");
            }
        }

        private void SetPrice()
        {
            newPriceLabel.Text = (product.Price * (100 - product.Discount) / 100.0m).ToString("F2");
            if (product.Discount > 0)
            {
                oldPriceLabel.Text = product.Price.ToString("F2");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (CanClickUserControl)
            {
                if (MessageBox.Show(
                    "Вы уверены что хотите удалить выбранный товар?",
                    "Подвтерждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        Program.Context.Products.Remove(product);
                    }
                    catch
                    {
                        MessageBox.Show("Этот товар удалить нельзя. Он заказан");
                    }
                    Program.Context.SaveChanges();
                }
            }
        }

        private async void photoPictureBox_Click(object sender, EventArgs e)
        {
            if (CanClickUserControl)
            {
                if (new EditProductForm(product).ShowDialog() == DialogResult.OK)
                {
                    await ContextManager.ProductForm.FillProducts();
                }
            }
        }
    }
}
