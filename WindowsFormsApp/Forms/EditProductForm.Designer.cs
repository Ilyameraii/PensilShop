namespace PensilShop.Forms
{
    partial class EditProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label articulLabel;
            System.Windows.Forms.Label productNameIdLabel;
            System.Windows.Forms.Label unitOfMeasurementIdLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label maxDiscountLabel;
            System.Windows.Forms.Label manufacturerIdLabel;
            System.Windows.Forms.Label supplierIdLabel;
            System.Windows.Forms.Label categoryIdLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label photoLabel;
            this.pensil_shopDataSet = new PensilShop.pensil_shopDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new PensilShop.pensil_shopDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new PensilShop.pensil_shopDataSetTableAdapters.TableAdapterManager();
            this.categoryTableAdapter = new PensilShop.pensil_shopDataSetTableAdapters.CategoryTableAdapter();
            this.manufacturerTableAdapter = new PensilShop.pensil_shopDataSetTableAdapters.ManufacturerTableAdapter();
            this.productNameTableAdapter = new PensilShop.pensil_shopDataSetTableAdapters.ProductNameTableAdapter();
            this.supplierTableAdapter = new PensilShop.pensil_shopDataSetTableAdapters.SupplierTableAdapter();
            this.unitOfMeasurementTableAdapter = new PensilShop.pensil_shopDataSetTableAdapters.UnitOfMeasurementTableAdapter();
            this.articulTextBox = new System.Windows.Forms.TextBox();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxDiscountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.discountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.productNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productNameComboBox = new System.Windows.Forms.ComboBox();
            this.unitOfMeasurementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitOfMeasurementComboBox = new System.Windows.Forms.ComboBox();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.fileButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            articulLabel = new System.Windows.Forms.Label();
            productNameIdLabel = new System.Windows.Forms.Label();
            unitOfMeasurementIdLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            maxDiscountLabel = new System.Windows.Forms.Label();
            manufacturerIdLabel = new System.Windows.Forms.Label();
            supplierIdLabel = new System.Windows.Forms.Label();
            categoryIdLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pensil_shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDiscountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasurementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.saveButton);
            this.splitContainer1.Panel2.Controls.Add(this.fileButton);
            this.splitContainer1.Panel2.Controls.Add(this.categoryComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.supplierComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.manufacturerComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.unitOfMeasurementComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.productNameComboBox);
            this.splitContainer1.Panel2.Controls.Add(articulLabel);
            this.splitContainer1.Panel2.Controls.Add(this.articulTextBox);
            this.splitContainer1.Panel2.Controls.Add(productNameIdLabel);
            this.splitContainer1.Panel2.Controls.Add(unitOfMeasurementIdLabel);
            this.splitContainer1.Panel2.Controls.Add(priceLabel);
            this.splitContainer1.Panel2.Controls.Add(this.priceNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(maxDiscountLabel);
            this.splitContainer1.Panel2.Controls.Add(this.maxDiscountNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(manufacturerIdLabel);
            this.splitContainer1.Panel2.Controls.Add(supplierIdLabel);
            this.splitContainer1.Panel2.Controls.Add(categoryIdLabel);
            this.splitContainer1.Panel2.Controls.Add(discountLabel);
            this.splitContainer1.Panel2.Controls.Add(this.discountNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(stockLabel);
            this.splitContainer1.Panel2.Controls.Add(this.stockNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(descriptionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.descriptionTextBox);
            this.splitContainer1.Panel2.Controls.Add(photoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.photoTextBox);
            // 
            // articulLabel
            // 
            articulLabel.AutoSize = true;
            articulLabel.Location = new System.Drawing.Point(179, 10);
            articulLabel.Name = "articulLabel";
            articulLabel.Size = new System.Drawing.Size(46, 15);
            articulLabel.TabIndex = 0;
            articulLabel.Text = "Articul:";
            // 
            // productNameIdLabel
            // 
            productNameIdLabel.AutoSize = true;
            productNameIdLabel.Location = new System.Drawing.Point(179, 33);
            productNameIdLabel.Name = "productNameIdLabel";
            productNameIdLabel.Size = new System.Drawing.Size(81, 15);
            productNameIdLabel.TabIndex = 2;
            productNameIdLabel.Text = "Product Name:";
            // 
            // unitOfMeasurementIdLabel
            // 
            unitOfMeasurementIdLabel.AutoSize = true;
            unitOfMeasurementIdLabel.Location = new System.Drawing.Point(179, 56);
            unitOfMeasurementIdLabel.Name = "unitOfMeasurementIdLabel";
            unitOfMeasurementIdLabel.Size = new System.Drawing.Size(121, 15);
            unitOfMeasurementIdLabel.TabIndex = 4;
            unitOfMeasurementIdLabel.Text = "Unit Of Measurement:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(179, 82);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(37, 15);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "Price:";
            // 
            // maxDiscountLabel
            // 
            maxDiscountLabel.AutoSize = true;
            maxDiscountLabel.Location = new System.Drawing.Point(179, 111);
            maxDiscountLabel.Name = "maxDiscountLabel";
            maxDiscountLabel.Size = new System.Drawing.Size(81, 15);
            maxDiscountLabel.TabIndex = 8;
            maxDiscountLabel.Text = "Max Discount:";
            // 
            // manufacturerIdLabel
            // 
            manufacturerIdLabel.AutoSize = true;
            manufacturerIdLabel.Location = new System.Drawing.Point(179, 137);
            manufacturerIdLabel.Name = "manufacturerIdLabel";
            manufacturerIdLabel.Size = new System.Drawing.Size(82, 15);
            manufacturerIdLabel.TabIndex = 10;
            manufacturerIdLabel.Text = "Manufacturer:";
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Location = new System.Drawing.Point(179, 160);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(54, 15);
            supplierIdLabel.TabIndex = 12;
            supplierIdLabel.Text = "Supplier:";
            // 
            // categoryIdLabel
            // 
            categoryIdLabel.AutoSize = true;
            categoryIdLabel.Location = new System.Drawing.Point(179, 183);
            categoryIdLabel.Name = "categoryIdLabel";
            categoryIdLabel.Size = new System.Drawing.Size(56, 15);
            categoryIdLabel.TabIndex = 14;
            categoryIdLabel.Text = "Category:";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new System.Drawing.Point(179, 209);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(55, 15);
            discountLabel.TabIndex = 16;
            discountLabel.Text = "Discount:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(179, 238);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(40, 15);
            stockLabel.TabIndex = 18;
            stockLabel.Text = "Stock:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(179, 270);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(70, 15);
            descriptionLabel.TabIndex = 20;
            descriptionLabel.Text = "Description:";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(179, 299);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(38, 15);
            photoLabel.TabIndex = 22;
            photoLabel.Text = "Photo:";
            // 
            // pensil_shopDataSet
            // 
            this.pensil_shopDataSet.DataSetName = "pensil_shopDataSet";
            this.pensil_shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.pensil_shopDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = this.categoryTableAdapter;
            this.tableAdapterManager.ManufacturerTableAdapter = this.manufacturerTableAdapter;
            this.tableAdapterManager.OfficeTableAdapter = null;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.ProductNameTableAdapter = this.productNameTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = this.supplierTableAdapter;
            this.tableAdapterManager.UnitOfMeasurementTableAdapter = this.unitOfMeasurementTableAdapter;
            this.tableAdapterManager.UpdateOrder = PensilShop.pensil_shopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // productNameTableAdapter
            // 
            this.productNameTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // unitOfMeasurementTableAdapter
            // 
            this.unitOfMeasurementTableAdapter.ClearBeforeFill = true;
            // 
            // articulTextBox
            // 
            this.articulTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Articul", true));
            this.articulTextBox.Location = new System.Drawing.Point(321, 7);
            this.articulTextBox.Name = "articulTextBox";
            this.articulTextBox.Size = new System.Drawing.Size(202, 23);
            this.articulTextBox.TabIndex = 1;
            this.articulTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.General_Validating);
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "Price", true));
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.priceNumericUpDown.Location = new System.Drawing.Point(321, 82);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.priceNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(202, 23);
            this.priceNumericUpDown.TabIndex = 7;
            this.priceNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // maxDiscountNumericUpDown
            // 
            this.maxDiscountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "MaxDiscount", true));
            this.maxDiscountNumericUpDown.Location = new System.Drawing.Point(321, 111);
            this.maxDiscountNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.maxDiscountNumericUpDown.Name = "maxDiscountNumericUpDown";
            this.maxDiscountNumericUpDown.Size = new System.Drawing.Size(202, 23);
            this.maxDiscountNumericUpDown.TabIndex = 9;
            this.maxDiscountNumericUpDown.Validating += new System.ComponentModel.CancelEventHandler(this.discountNumericUpDown_Validating);
            // 
            // discountNumericUpDown
            // 
            this.discountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "Discount", true));
            this.discountNumericUpDown.Location = new System.Drawing.Point(321, 209);
            this.discountNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.discountNumericUpDown.Name = "discountNumericUpDown";
            this.discountNumericUpDown.Size = new System.Drawing.Size(202, 23);
            this.discountNumericUpDown.TabIndex = 17;
            this.discountNumericUpDown.Validating += new System.ComponentModel.CancelEventHandler(this.discountNumericUpDown_Validating);
            // 
            // stockNumericUpDown
            // 
            this.stockNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "Stock", true));
            this.stockNumericUpDown.Location = new System.Drawing.Point(321, 238);
            this.stockNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.stockNumericUpDown.Name = "stockNumericUpDown";
            this.stockNumericUpDown.Size = new System.Drawing.Size(202, 23);
            this.stockNumericUpDown.TabIndex = 19;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(321, 267);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(202, 23);
            this.descriptionTextBox.TabIndex = 21;
            this.descriptionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.General_Validating);
            // 
            // photoTextBox
            // 
            this.photoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Photo", true));
            this.photoTextBox.Location = new System.Drawing.Point(321, 296);
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.ReadOnly = true;
            this.photoTextBox.Size = new System.Drawing.Size(106, 23);
            this.photoTextBox.TabIndex = 23;
            // 
            // productNameBindingSource
            // 
            this.productNameBindingSource.DataMember = "ProductName";
            this.productNameBindingSource.DataSource = this.pensil_shopDataSet;
            // 
            // productNameComboBox
            // 
            this.productNameComboBox.DataSource = this.productNameBindingSource;
            this.productNameComboBox.DisplayMember = "Name";
            this.productNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productNameComboBox.FormattingEnabled = true;
            this.productNameComboBox.Location = new System.Drawing.Point(321, 31);
            this.productNameComboBox.Name = "productNameComboBox";
            this.productNameComboBox.Size = new System.Drawing.Size(202, 23);
            this.productNameComboBox.TabIndex = 24;
            this.productNameComboBox.ValueMember = "Id";
            this.productNameComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.General_Validating);
            // 
            // unitOfMeasurementBindingSource
            // 
            this.unitOfMeasurementBindingSource.DataMember = "UnitOfMeasurement";
            this.unitOfMeasurementBindingSource.DataSource = this.pensil_shopDataSet;
            // 
            // unitOfMeasurementComboBox
            // 
            this.unitOfMeasurementComboBox.DataSource = this.unitOfMeasurementBindingSource;
            this.unitOfMeasurementComboBox.DisplayMember = "Name";
            this.unitOfMeasurementComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitOfMeasurementComboBox.FormattingEnabled = true;
            this.unitOfMeasurementComboBox.Location = new System.Drawing.Point(321, 56);
            this.unitOfMeasurementComboBox.Name = "unitOfMeasurementComboBox";
            this.unitOfMeasurementComboBox.Size = new System.Drawing.Size(202, 23);
            this.unitOfMeasurementComboBox.TabIndex = 24;
            this.unitOfMeasurementComboBox.ValueMember = "Id";
            this.unitOfMeasurementComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.General_Validating);
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.pensil_shopDataSet;
            // 
            // manufacturerComboBox
            // 
            this.manufacturerComboBox.DataSource = this.manufacturerBindingSource;
            this.manufacturerComboBox.DisplayMember = "Name";
            this.manufacturerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturerComboBox.FormattingEnabled = true;
            this.manufacturerComboBox.Location = new System.Drawing.Point(321, 137);
            this.manufacturerComboBox.Name = "manufacturerComboBox";
            this.manufacturerComboBox.Size = new System.Drawing.Size(202, 23);
            this.manufacturerComboBox.TabIndex = 24;
            this.manufacturerComboBox.ValueMember = "Id";
            this.manufacturerComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.General_Validating);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.pensil_shopDataSet;
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.DataSource = this.supplierBindingSource;
            this.supplierComboBox.DisplayMember = "Name";
            this.supplierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(321, 161);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(202, 23);
            this.supplierComboBox.TabIndex = 24;
            this.supplierComboBox.ValueMember = "Id";
            this.supplierComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.General_Validating);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.pensil_shopDataSet;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(321, 185);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(202, 23);
            this.categoryComboBox.TabIndex = 24;
            this.categoryComboBox.ValueMember = "Id";
            this.categoryComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.General_Validating);
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(448, 296);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(75, 23);
            this.fileButton.TabIndex = 25;
            this.fileButton.Text = "Файл";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.saveButton.Location = new System.Drawing.Point(321, 320);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(202, 23);
            this.saveButton.TabIndex = 26;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Изображения(*.jpeg;*.jpg;*.png)|*.jpeg;*.jpg;*.png";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "EditProduct";
            this.Text = "EditProduct";
            this.Load += new System.EventHandler(this.EditProduct_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pensil_shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDiscountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasurementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private pensil_shopDataSet pensil_shopDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private pensil_shopDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private pensil_shopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox articulTextBox;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.NumericUpDown maxDiscountNumericUpDown;
        private System.Windows.Forms.NumericUpDown discountNumericUpDown;
        private System.Windows.Forms.NumericUpDown stockNumericUpDown;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox photoTextBox;
        private pensil_shopDataSetTableAdapters.ProductNameTableAdapter productNameTableAdapter;
        private System.Windows.Forms.BindingSource productNameBindingSource;
        private System.Windows.Forms.ComboBox productNameComboBox;
        private pensil_shopDataSetTableAdapters.UnitOfMeasurementTableAdapter unitOfMeasurementTableAdapter;
        private System.Windows.Forms.BindingSource unitOfMeasurementBindingSource;
        private System.Windows.Forms.ComboBox unitOfMeasurementComboBox;
        private pensil_shopDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private System.Windows.Forms.ComboBox manufacturerComboBox;
        private pensil_shopDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private pensil_shopDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}