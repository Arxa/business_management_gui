namespace Digital_Storehouse.Views
{
    partial class UpdateOrder
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
            this.customerId_F_label = new System.Windows.Forms.Label();
            this.deliveryLocation_label = new System.Windows.Forms.Label();
            this.orderData_label = new System.Windows.Forms.Label();
            this.paymentMethod_label = new System.Windows.Forms.Label();
            this.orderDate_picker = new System.Windows.Forms.DateTimePicker();
            this.customerId_combobox = new System.Windows.Forms.ComboBox();
            this.paymentMethod_combobox = new System.Windows.Forms.ComboBox();
            this.deliveryLocation_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.are_required_label = new System.Windows.Forms.Label();
            this.asterix_warning = new System.Windows.Forms.Label();
            this.all_fields_marked_with_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerId_F_label
            // 
            this.customerId_F_label.AutoSize = true;
            this.customerId_F_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.customerId_F_label.Location = new System.Drawing.Point(59, 101);
            this.customerId_F_label.Name = "customerId_F_label";
            this.customerId_F_label.Size = new System.Drawing.Size(100, 13);
            this.customerId_F_label.TabIndex = 96;
            this.customerId_F_label.Text = "CUSTOMER_ID:";
            // 
            // deliveryLocation_label
            // 
            this.deliveryLocation_label.AutoSize = true;
            this.deliveryLocation_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deliveryLocation_label.Location = new System.Drawing.Point(59, 194);
            this.deliveryLocation_label.Name = "deliveryLocation_label";
            this.deliveryLocation_label.Size = new System.Drawing.Size(141, 13);
            this.deliveryLocation_label.TabIndex = 95;
            this.deliveryLocation_label.Text = "DELIVERY_LOCATION:";
            // 
            // orderData_label
            // 
            this.orderData_label.AutoSize = true;
            this.orderData_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.orderData_label.Location = new System.Drawing.Point(59, 54);
            this.orderData_label.Name = "orderData_label";
            this.orderData_label.Size = new System.Drawing.Size(95, 13);
            this.orderData_label.TabIndex = 94;
            this.orderData_label.Text = "ORDER_DATE:";
            // 
            // paymentMethod_label
            // 
            this.paymentMethod_label.AutoSize = true;
            this.paymentMethod_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.paymentMethod_label.Location = new System.Drawing.Point(59, 148);
            this.paymentMethod_label.Name = "paymentMethod_label";
            this.paymentMethod_label.Size = new System.Drawing.Size(130, 13);
            this.paymentMethod_label.TabIndex = 93;
            this.paymentMethod_label.Text = "PAYMENT_METHOD:";
            // 
            // orderDate_picker
            // 
            this.orderDate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.orderDate_picker.Location = new System.Drawing.Point(218, 48);
            this.orderDate_picker.Name = "orderDate_picker";
            this.orderDate_picker.Size = new System.Drawing.Size(97, 20);
            this.orderDate_picker.TabIndex = 97;
            // 
            // customerId_combobox
            // 
            this.customerId_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerId_combobox.FormattingEnabled = true;
            this.customerId_combobox.Location = new System.Drawing.Point(218, 92);
            this.customerId_combobox.Name = "customerId_combobox";
            this.customerId_combobox.Size = new System.Drawing.Size(40, 21);
            this.customerId_combobox.TabIndex = 98;
            // 
            // paymentMethod_combobox
            // 
            this.paymentMethod_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethod_combobox.FormattingEnabled = true;
            this.paymentMethod_combobox.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Check",
            "Coupon"});
            this.paymentMethod_combobox.Location = new System.Drawing.Point(218, 140);
            this.paymentMethod_combobox.Name = "paymentMethod_combobox";
            this.paymentMethod_combobox.Size = new System.Drawing.Size(80, 21);
            this.paymentMethod_combobox.TabIndex = 99;
            // 
            // deliveryLocation_textbox
            // 
            this.deliveryLocation_textbox.Location = new System.Drawing.Point(218, 187);
            this.deliveryLocation_textbox.MaxLength = 50;
            this.deliveryLocation_textbox.Name = "deliveryLocation_textbox";
            this.deliveryLocation_textbox.Size = new System.Drawing.Size(123, 20);
            this.deliveryLocation_textbox.TabIndex = 100;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(223, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 101;
            this.button1.Text = "Update Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.FlatAppearance.BorderSize = 0;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancel_button.Location = new System.Drawing.Point(88, 268);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 102;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // are_required_label
            // 
            this.are_required_label.AutoSize = true;
            this.are_required_label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.are_required_label.Location = new System.Drawing.Point(140, 9);
            this.are_required_label.Name = "are_required_label";
            this.are_required_label.Size = new System.Drawing.Size(73, 13);
            this.are_required_label.TabIndex = 117;
            this.are_required_label.Text = "are required.";
            // 
            // asterix_warning
            // 
            this.asterix_warning.AutoSize = true;
            this.asterix_warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.asterix_warning.ForeColor = System.Drawing.Color.Red;
            this.asterix_warning.Location = new System.Drawing.Point(127, 9);
            this.asterix_warning.Name = "asterix_warning";
            this.asterix_warning.Size = new System.Drawing.Size(18, 24);
            this.asterix_warning.TabIndex = 116;
            this.asterix_warning.Text = "*";
            // 
            // all_fields_marked_with_label
            // 
            this.all_fields_marked_with_label.AutoSize = true;
            this.all_fields_marked_with_label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.all_fields_marked_with_label.Location = new System.Drawing.Point(12, 9);
            this.all_fields_marked_with_label.Name = "all_fields_marked_with_label";
            this.all_fields_marked_with_label.Size = new System.Drawing.Size(118, 13);
            this.all_fields_marked_with_label.TabIndex = 115;
            this.all_fields_marked_with_label.Text = "All fields marked with";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(35, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 24);
            this.label1.TabIndex = 118;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(35, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 24);
            this.label2.TabIndex = 119;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(35, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 24);
            this.label3.TabIndex = 120;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(35, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 24);
            this.label4.TabIndex = 121;
            this.label4.Text = "*";
            // 
            // UpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 326);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.are_required_label);
            this.Controls.Add(this.asterix_warning);
            this.Controls.Add(this.all_fields_marked_with_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deliveryLocation_textbox);
            this.Controls.Add(this.paymentMethod_combobox);
            this.Controls.Add(this.customerId_combobox);
            this.Controls.Add(this.orderDate_picker);
            this.Controls.Add(this.customerId_F_label);
            this.Controls.Add(this.deliveryLocation_label);
            this.Controls.Add(this.orderData_label);
            this.Controls.Add(this.paymentMethod_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdateOrder";
            this.Text = "UpdateOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerId_F_label;
        private System.Windows.Forms.Label deliveryLocation_label;
        private System.Windows.Forms.Label orderData_label;
        private System.Windows.Forms.Label paymentMethod_label;
        private System.Windows.Forms.DateTimePicker orderDate_picker;
        private System.Windows.Forms.ComboBox customerId_combobox;
        private System.Windows.Forms.ComboBox paymentMethod_combobox;
        private System.Windows.Forms.TextBox deliveryLocation_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label are_required_label;
        private System.Windows.Forms.Label asterix_warning;
        private System.Windows.Forms.Label all_fields_marked_with_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}