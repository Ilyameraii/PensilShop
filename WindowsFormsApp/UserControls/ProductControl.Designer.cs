namespace PensilShop.UserControls
{
    partial class ProductControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.stockLabel = new System.Windows.Forms.Label();
            this.unitOfMeasurementLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.oldPriceLabel = new System.Windows.Forms.Label();
            this.newPriceLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.discountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Location = new System.Drawing.Point(10, 10);
            this.photoPictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(130, 130);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPictureBox.TabIndex = 0;
            this.photoPictureBox.TabStop = false;
            this.photoPictureBox.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.stockLabel);
            this.panel1.Controls.Add(this.unitOfMeasurementLabel);
            this.panel1.Controls.Add(this.supplierLabel);
            this.panel1.Controls.Add(this.manufacturerLabel);
            this.panel1.Controls.Add(this.descriptionLabel);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(153, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 130);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.deleteButton.Location = new System.Drawing.Point(354, 102);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(6, 113);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(129, 15);
            this.stockLabel.TabIndex = 6;
            this.stockLabel.Text = "Количество на складе:";
            this.stockLabel.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // unitOfMeasurementLabel
            // 
            this.unitOfMeasurementLabel.AutoSize = true;
            this.unitOfMeasurementLabel.Location = new System.Drawing.Point(6, 98);
            this.unitOfMeasurementLabel.Name = "unitOfMeasurementLabel";
            this.unitOfMeasurementLabel.Size = new System.Drawing.Size(117, 15);
            this.unitOfMeasurementLabel.TabIndex = 5;
            this.unitOfMeasurementLabel.Text = "Единица измерения:";
            this.unitOfMeasurementLabel.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(6, 56);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(71, 15);
            this.supplierLabel.TabIndex = 4;
            this.supplierLabel.Text = "Поставщик:";
            this.supplierLabel.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(6, 41);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(95, 15);
            this.manufacturerLabel.TabIndex = 3;
            this.manufacturerLabel.Text = "Производитель:";
            this.manufacturerLabel.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(6, 26);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(103, 15);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Описание товара:";
            this.descriptionLabel.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.oldPriceLabel);
            this.flowLayoutPanel2.Controls.Add(this.newPriceLabel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(9, 74);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(428, 21);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Цена:";
            this.label7.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // oldPriceLabel
            // 
            this.oldPriceLabel.AutoSize = true;
            this.oldPriceLabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPriceLabel.ForeColor = System.Drawing.Color.Red;
            this.oldPriceLabel.Location = new System.Drawing.Point(46, 0);
            this.oldPriceLabel.Name = "oldPriceLabel";
            this.oldPriceLabel.Size = new System.Drawing.Size(0, 15);
            this.oldPriceLabel.TabIndex = 8;
            this.oldPriceLabel.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // newPriceLabel
            // 
            this.newPriceLabel.AutoSize = true;
            this.newPriceLabel.Location = new System.Drawing.Point(52, 0);
            this.newPriceLabel.Name = "newPriceLabel";
            this.newPriceLabel.Size = new System.Drawing.Size(0, 15);
            this.newPriceLabel.TabIndex = 9;
            this.newPriceLabel.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.categoryLabel);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.nameLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(428, 20);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(3, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(101, 15);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "Категория товара";
            this.categoryLabel.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "|";
            this.label2.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(127, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(125, 15);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Наименование товара";
            this.nameLabel.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.discountLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(610, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 130);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // discountLabel
            // 
            this.discountLabel.Location = new System.Drawing.Point(3, 41);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(126, 30);
            this.discountLabel.TabIndex = 1;
            this.discountLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.discountLabel.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Действующая скидка: ";
            this.label1.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.photoPictureBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(750, 150);
            this.Click += new System.EventHandler(this.photoPictureBox_Click);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label unitOfMeasurementLabel;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label oldPriceLabel;
        private System.Windows.Forms.Label newPriceLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
    }
}
