namespace PensilShop.Forms
{
    partial class EditOrderForm
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
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label deliveryDateLabel;
            System.Windows.Forms.Label officeIdLabel;
            System.Windows.Forms.Label userIdLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label receiveCodeLabel;
            System.Windows.Forms.Label statusIdLabel;
            this.pensil_shopDataSet = new PensilShop.pensil_shopDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new PensilShop.pensil_shopDataSetTableAdapters.OrderTableAdapter();
            this.tableAdapterManager = new PensilShop.pensil_shopDataSetTableAdapters.TableAdapterManager();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deliveryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.receiveCodeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.officeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officeTableAdapter = new PensilShop.pensil_shopDataSetTableAdapters.OfficeTableAdapter();
            this.officeComboBox = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new PensilShop.pensil_shopDataSetTableAdapters.UserTableAdapter();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new PensilShop.pensil_shopDataSetTableAdapters.StatusTableAdapter();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            dateLabel = new System.Windows.Forms.Label();
            deliveryDateLabel = new System.Windows.Forms.Label();
            officeIdLabel = new System.Windows.Forms.Label();
            userIdLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            receiveCodeLabel = new System.Windows.Forms.Label();
            statusIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pensil_shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiveCodeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.statusComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.userComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.officeComboBox);
            this.splitContainer1.Panel2.Controls.Add(dateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.dateDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(deliveryDateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.deliveryDateDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(officeIdLabel);
            this.splitContainer1.Panel2.Controls.Add(userIdLabel);
            this.splitContainer1.Panel2.Controls.Add(emailLabel);
            this.splitContainer1.Panel2.Controls.Add(this.emailTextBox);
            this.splitContainer1.Panel2.Controls.Add(receiveCodeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.receiveCodeNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(statusIdLabel);
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(216, 48);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(34, 15);
            dateLabel.TabIndex = 0;
            dateLabel.Text = "Date:";
            // 
            // deliveryDateLabel
            // 
            deliveryDateLabel.AutoSize = true;
            deliveryDateLabel.Location = new System.Drawing.Point(216, 77);
            deliveryDateLabel.Name = "deliveryDateLabel";
            deliveryDateLabel.Size = new System.Drawing.Size(81, 15);
            deliveryDateLabel.TabIndex = 2;
            deliveryDateLabel.Text = "Delivery Date:";
            // 
            // officeIdLabel
            // 
            officeIdLabel.AutoSize = true;
            officeIdLabel.Location = new System.Drawing.Point(216, 99);
            officeIdLabel.Name = "officeIdLabel";
            officeIdLabel.Size = new System.Drawing.Size(47, 15);
            officeIdLabel.TabIndex = 4;
            officeIdLabel.Text = "Office:";
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new System.Drawing.Point(216, 122);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(40, 15);
            userIdLabel.TabIndex = 6;
            userIdLabel.Text = "Client:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(216, 151);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(38, 15);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email:";
            // 
            // receiveCodeLabel
            // 
            receiveCodeLabel.AutoSize = true;
            receiveCodeLabel.Location = new System.Drawing.Point(216, 177);
            receiveCodeLabel.Name = "receiveCodeLabel";
            receiveCodeLabel.Size = new System.Drawing.Size(79, 15);
            receiveCodeLabel.TabIndex = 10;
            receiveCodeLabel.Text = "Receive Code:";
            // 
            // statusIdLabel
            // 
            statusIdLabel.AutoSize = true;
            statusIdLabel.Location = new System.Drawing.Point(216, 203);
            statusIdLabel.Name = "statusIdLabel";
            statusIdLabel.Size = new System.Drawing.Size(43, 15);
            statusIdLabel.TabIndex = 12;
            statusIdLabel.Text = "Status:";
            // 
            // pensil_shopDataSet
            // 
            this.pensil_shopDataSet.DataSetName = "pensil_shopDataSet";
            this.pensil_shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.pensil_shopDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.OfficeTableAdapter = null;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.ProductNameTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UnitOfMeasurementTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PensilShop.pensil_shopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(303, 44);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateDateTimePicker.TabIndex = 1;
            this.dateDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.dateDateTimePicker_Validating);
            // 
            // deliveryDateDateTimePicker
            // 
            this.deliveryDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "DeliveryDate", true));
            this.deliveryDateDateTimePicker.Location = new System.Drawing.Point(303, 73);
            this.deliveryDateDateTimePicker.Name = "deliveryDateDateTimePicker";
            this.deliveryDateDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.deliveryDateDateTimePicker.TabIndex = 3;
            this.deliveryDateDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.dateDateTimePicker_Validating);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(303, 148);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 23);
            this.emailTextBox.TabIndex = 9;
            this.emailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.General_Validating);
            // 
            // receiveCodeNumericUpDown
            // 
            this.receiveCodeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "ReceiveCode", true));
            this.receiveCodeNumericUpDown.Location = new System.Drawing.Point(303, 177);
            this.receiveCodeNumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.receiveCodeNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.receiveCodeNumericUpDown.Name = "receiveCodeNumericUpDown";
            this.receiveCodeNumericUpDown.Size = new System.Drawing.Size(200, 23);
            this.receiveCodeNumericUpDown.TabIndex = 11;
            this.receiveCodeNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // officeBindingSource
            // 
            this.officeBindingSource.DataMember = "Office";
            this.officeBindingSource.DataSource = this.pensil_shopDataSet;
            // 
            // officeTableAdapter
            // 
            this.officeTableAdapter.ClearBeforeFill = true;
            // 
            // officeComboBox
            // 
            this.officeComboBox.DataSource = this.officeBindingSource;
            this.officeComboBox.DisplayMember = "Address";
            this.officeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.officeComboBox.FormattingEnabled = true;
            this.officeComboBox.Location = new System.Drawing.Point(303, 98);
            this.officeComboBox.Name = "officeComboBox";
            this.officeComboBox.Size = new System.Drawing.Size(200, 23);
            this.officeComboBox.TabIndex = 14;
            this.officeComboBox.ValueMember = "Id";
            this.officeComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.General_Validating);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.pensil_shopDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // userComboBox
            // 
            this.userComboBox.DataSource = this.userBindingSource;
            this.userComboBox.DisplayMember = "FullName";
            this.userComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(303, 123);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(200, 23);
            this.userComboBox.TabIndex = 14;
            this.userComboBox.ValueMember = "Id";
            this.userComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.General_Validating);
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.pensil_shopDataSet;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataSource = this.statusBindingSource;
            this.statusComboBox.DisplayMember = "Name";
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(303, 203);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(200, 23);
            this.statusComboBox.TabIndex = 14;
            this.statusComboBox.ValueMember = "Id";
            this.statusComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.General_Validating);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.saveButton.Location = new System.Drawing.Point(303, 232);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(202, 23);
            this.saveButton.TabIndex = 27;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "EditOrderForm";
            this.Text = "EditOrderForm";
            this.Load += new System.EventHandler(this.EditOrderForm_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pensil_shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiveCodeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private pensil_shopDataSet pensil_shopDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private pensil_shopDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private pensil_shopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker deliveryDateDateTimePicker;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.NumericUpDown receiveCodeNumericUpDown;
        private System.Windows.Forms.BindingSource officeBindingSource;
        private pensil_shopDataSetTableAdapters.OfficeTableAdapter officeTableAdapter;
        private System.Windows.Forms.ComboBox officeComboBox;
        private System.Windows.Forms.BindingSource userBindingSource;
        private pensil_shopDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private pensil_shopDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}