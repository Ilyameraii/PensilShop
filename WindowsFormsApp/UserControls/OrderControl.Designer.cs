namespace PensilShop.UserControls
{
    partial class OrderControl
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
            this.articulLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deliveryDatelabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // articulLabel
            // 
            this.articulLabel.AutoSize = true;
            this.articulLabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.articulLabel.Location = new System.Drawing.Point(55, 12);
            this.articulLabel.Name = "articulLabel";
            this.articulLabel.Size = new System.Drawing.Size(99, 16);
            this.articulLabel.TabIndex = 0;
            this.articulLabel.Text = "Артикул заказа: ";
            this.articulLabel.Click += new System.EventHandler(this.userControl_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(55, 40);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(84, 15);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Статус заказа: ";
            this.statusLabel.Click += new System.EventHandler(this.userControl_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(55, 69);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(128, 15);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Адрес пункта выдачи: ";
            this.addressLabel.Click += new System.EventHandler(this.userControl_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(53, 103);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(74, 15);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Дата заказа: ";
            this.dateLabel.Click += new System.EventHandler(this.userControl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата доставки";
            this.label5.Click += new System.EventHandler(this.userControl_Click);
            // 
            // deliveryDatelabel
            // 
            this.deliveryDatelabel.Location = new System.Drawing.Point(552, 62);
            this.deliveryDatelabel.Name = "deliveryDatelabel";
            this.deliveryDatelabel.Size = new System.Drawing.Size(128, 22);
            this.deliveryDatelabel.TabIndex = 5;
            this.deliveryDatelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deliveryDatelabel.Click += new System.EventHandler(this.userControl_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.deleteButton.Location = new System.Drawing.Point(479, 122);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.deliveryDatelabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.articulLabel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(748, 148);
            this.Click += new System.EventHandler(this.userControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label articulLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label deliveryDatelabel;
        private System.Windows.Forms.Button deleteButton;
    }
}
