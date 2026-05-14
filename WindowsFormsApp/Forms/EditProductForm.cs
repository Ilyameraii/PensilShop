using PensilShop.Models;
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

namespace PensilShop.Forms
{
    public partial class EditProductForm : ParentForm
    {
        private Product product;
        public EditProductForm(Product product = null)
        {
            InitializeComponent();
            if (product != null)
            {
                this.product = product;
            }
            else
            {
                this.product = new Product
                {
                    Id = 0,
                    Price = 0.010m,
                };
            }
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pensil_shopDataSet);

        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pensil_shopDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.pensil_shopDataSet.Category);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pensil_shopDataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.pensil_shopDataSet.Supplier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pensil_shopDataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.pensil_shopDataSet.Manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pensil_shopDataSet.UnitOfMeasurement". При необходимости она может быть перемещена или удалена.
            this.unitOfMeasurementTableAdapter.Fill(this.pensil_shopDataSet.UnitOfMeasurement);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pensil_shopDataSet.ProductName". При необходимости она может быть перемещена или удалена.
            this.productNameTableAdapter.Fill(this.pensil_shopDataSet.ProductName);
            FillForm();
        }

        private void FillForm()
        {
            articulTextBox.Text = product.Articul;
            productNameComboBox.SelectedValue = product.ProductNameId;
            unitOfMeasurementComboBox.SelectedValue = product.UnitOfMeasurementId;
            priceNumericUpDown.Value = product.Price;
            maxDiscountNumericUpDown.Value = product.MaxDiscount;
            manufacturerComboBox.SelectedValue = product.ManufacturerId;
            supplierComboBox.SelectedValue = product.SupplierId;
            categoryComboBox.SelectedValue = product.CategoryId;
            discountNumericUpDown.Value = product.Discount;
            stockNumericUpDown.Value = product.Stock;
            descriptionTextBox.Text = product.Description;
            photoTextBox.Text = product.Photo;
        }

        private void productBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pensil_shopDataSet);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }
            FillProduct();

            if (product.Id == 0)
            {
                Program.Context.Products.Add(product);
            }
            Program.Context.SaveChanges();

            DialogResult = DialogResult.OK;
        }
        private void FillProduct()
        {
            product.Articul = articulTextBox.Text;
            product.ProductNameId = (int)productNameComboBox.SelectedValue;
            product.UnitOfMeasurementId = (int)unitOfMeasurementComboBox.SelectedValue;
            product.Price = priceNumericUpDown.Value;
            product.MaxDiscount = (int)maxDiscountNumericUpDown.Value;
            product.ManufacturerId = (int)manufacturerComboBox.SelectedValue;
            product.SupplierId = (int)supplierComboBox.SelectedValue;
            product.CategoryId = (int)categoryComboBox.SelectedValue;
            product.Discount = (int)discountNumericUpDown.Value;
            product.Stock = (int)stockNumericUpDown.Value;
            product.Description = descriptionTextBox.Text;
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                var newFileName = Guid.NewGuid().ToString().Substring(0, 8) + ".jpg";

                try
                {
                    File.Copy(openFileDialog1.FileName,
                        Path.Combine(
                            Application.StartupPath, "img", newFileName)
                        );
                }
                catch
                {
                    MessageBox.Show("Не удалось установить новую фотографию");
                }

                if (!string.IsNullOrWhiteSpace(product.Photo))
                {
                    try
                    {
                        File.Delete(
                            Path.Combine(
                                Application.StartupPath,  "img", product.Photo)
                            );
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось удалить старую фотографию");
                    }
                }

                product.Photo = newFileName;
            }
        }
        private void fileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                photoTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void General_Validating(object sender, CancelEventArgs e)
        {
            ValidationService.General_Validating(sender, e);
        }

        private void discountNumericUpDown_Validating(object sender, CancelEventArgs e)
        {
            var control = sender as Control;
            if (maxDiscountNumericUpDown.Value < discountNumericUpDown.Value)
            {
                errorProvider1.SetError(control, "Максимальная скидка не должна быть меньше текущей скидки");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(control, string.Empty);
            }
        }
    }
}
