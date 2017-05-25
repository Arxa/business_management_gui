namespace Digital_Storehouse.Views
{
    partial class NewOrder
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
            this.customerId_F_combobox = new System.Windows.Forms.ComboBox();
            this.customerId_F_label = new System.Windows.Forms.Label();
            this.deliveryLocation_label = new System.Windows.Forms.Label();
            this.orderDate_label = new System.Windows.Forms.Label();
            this.paymentMethod_label = new System.Windows.Forms.Label();
            this.addOrder_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.deliveryLocation_textbox = new Digital_Storehouse.Models.MyTextBox();
            this.orderDate_picker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // customerId_F_combobox
            // 
            this.customerId_F_combobox.FormattingEnabled = true;
            this.customerId_F_combobox.Location = new System.Drawing.Point(174, 131);
            this.customerId_F_combobox.Name = "customerId_F_combobox";
            this.customerId_F_combobox.Size = new System.Drawing.Size(38, 21);
            this.customerId_F_combobox.TabIndex = 101;
            // 
            // customerId_F_label
            // 
            this.customerId_F_label.AutoSize = true;
            this.customerId_F_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.customerId_F_label.Location = new System.Drawing.Point(62, 134);
            this.customerId_F_label.Name = "customerId_F_label";
            this.customerId_F_label.Size = new System.Drawing.Size(100, 13);
            this.customerId_F_label.TabIndex = 96;
            this.customerId_F_label.Text = "CUSTOMER_ID:";
            // 
            // deliveryLocation_label
            // 
            this.deliveryLocation_label.AutoSize = true;
            this.deliveryLocation_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deliveryLocation_label.Location = new System.Drawing.Point(386, 137);
            this.deliveryLocation_label.Name = "deliveryLocation_label";
            this.deliveryLocation_label.Size = new System.Drawing.Size(141, 13);
            this.deliveryLocation_label.TabIndex = 95;
            this.deliveryLocation_label.Text = "DELIVERY_LOCATION:";
            // 
            // orderDate_label
            // 
            this.orderDate_label.AutoSize = true;
            this.orderDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.orderDate_label.Location = new System.Drawing.Point(62, 81);
            this.orderDate_label.Name = "orderDate_label";
            this.orderDate_label.Size = new System.Drawing.Size(95, 13);
            this.orderDate_label.TabIndex = 94;
            this.orderDate_label.Text = "ORDER_DATE:";
            // 
            // paymentMethod_label
            // 
            this.paymentMethod_label.AutoSize = true;
            this.paymentMethod_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.paymentMethod_label.Location = new System.Drawing.Point(386, 81);
            this.paymentMethod_label.Name = "paymentMethod_label";
            this.paymentMethod_label.Size = new System.Drawing.Size(130, 13);
            this.paymentMethod_label.TabIndex = 93;
            this.paymentMethod_label.Text = "PAYMENT_METHOD:";
            // 
            // addOrder_button
            // 
            this.addOrder_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addOrder_button.ForeColor = System.Drawing.Color.Green;
            this.addOrder_button.Location = new System.Drawing.Point(369, 340);
            this.addOrder_button.Name = "addOrder_button";
            this.addOrder_button.Size = new System.Drawing.Size(83, 23);
            this.addOrder_button.TabIndex = 102;
            this.addOrder_button.Text = "Add Order";
            this.addOrder_button.UseVisualStyleBackColor = true;
            this.addOrder_button.Click += new System.EventHandler(this.addOrder_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancel_button.Location = new System.Drawing.Point(202, 340);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(83, 23);
            this.cancel_button.TabIndex = 103;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // deliveryLocation_textbox
            // 
            this.deliveryLocation_textbox.Location = new System.Drawing.Point(547, 134);
            this.deliveryLocation_textbox.Name = "deliveryLocation_textbox";
            this.deliveryLocation_textbox.Size = new System.Drawing.Size(100, 20);
            this.deliveryLocation_textbox.TabIndex = 107;
            // 
            // orderDate_picker
            // 
            this.orderDate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.orderDate_picker.Location = new System.Drawing.Point(174, 78);
            this.orderDate_picker.Name = "orderDate_picker";
            this.orderDate_picker.Size = new System.Drawing.Size(100, 20);
            this.orderDate_picker.TabIndex = 108;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(547, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(72, 21);
            this.comboBox1.TabIndex = 109;
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 473);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.orderDate_picker);
            this.Controls.Add(this.deliveryLocation_textbox);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.addOrder_button);
            this.Controls.Add(this.customerId_F_combobox);
            this.Controls.Add(this.customerId_F_label);
            this.Controls.Add(this.deliveryLocation_label);
            this.Controls.Add(this.orderDate_label);
            this.Controls.Add(this.paymentMethod_label);
            this.Name = "NewOrder";
            this.Text = "NewOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customerId_F_combobox;
        private System.Windows.Forms.Label customerId_F_label;
        private System.Windows.Forms.Label deliveryLocation_label;
        private System.Windows.Forms.Label orderDate_label;
        private System.Windows.Forms.Label paymentMethod_label;
        private System.Windows.Forms.Button addOrder_button;
        private System.Windows.Forms.Button cancel_button;
        private Models.MyTextBox deliveryLocation_textbox;
        private System.Windows.Forms.DateTimePicker orderDate_picker;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}