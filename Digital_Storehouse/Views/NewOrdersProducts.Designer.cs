namespace Digital_Storehouse.Views
{
    partial class NewOrdersProducts
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
            this.amount_label = new System.Windows.Forms.Label();
            this.idProduct_label = new System.Windows.Forms.Label();
            this.idOrder_label = new System.Windows.Forms.Label();
            this.amount_textbox = new System.Windows.Forms.TextBox();
            this.orderId_combobox = new System.Windows.Forms.ComboBox();
            this.productId_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addRelationship_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.are_required_label = new System.Windows.Forms.Label();
            this.asterix_warning = new System.Windows.Forms.Label();
            this.all_fields_marked_with_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.amount_label.Location = new System.Drawing.Point(69, 180);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(64, 13);
            this.amount_label.TabIndex = 108;
            this.amount_label.Text = "AMOUNT:";
            // 
            // idProduct_label
            // 
            this.idProduct_label.AutoSize = true;
            this.idProduct_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.idProduct_label.Location = new System.Drawing.Point(69, 128);
            this.idProduct_label.Name = "idProduct_label";
            this.idProduct_label.Size = new System.Drawing.Size(91, 13);
            this.idProduct_label.TabIndex = 107;
            this.idProduct_label.Text = "PRODUCT_ID:";
            // 
            // idOrder_label
            // 
            this.idOrder_label.AutoSize = true;
            this.idOrder_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.idOrder_label.Location = new System.Drawing.Point(69, 72);
            this.idOrder_label.Name = "idOrder_label";
            this.idOrder_label.Size = new System.Drawing.Size(75, 13);
            this.idOrder_label.TabIndex = 106;
            this.idOrder_label.Text = "ORDER_ID:";
            // 
            // amount_textbox
            // 
            this.amount_textbox.Location = new System.Drawing.Point(217, 177);
            this.amount_textbox.MaxLength = 10;
            this.amount_textbox.Name = "amount_textbox";
            this.amount_textbox.Size = new System.Drawing.Size(49, 20);
            this.amount_textbox.TabIndex = 111;
            // 
            // orderId_combobox
            // 
            this.orderId_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderId_combobox.FormattingEnabled = true;
            this.orderId_combobox.Location = new System.Drawing.Point(217, 69);
            this.orderId_combobox.Name = "orderId_combobox";
            this.orderId_combobox.Size = new System.Drawing.Size(43, 21);
            this.orderId_combobox.TabIndex = 112;
            // 
            // productId_combobox
            // 
            this.productId_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productId_combobox.FormattingEnabled = true;
            this.productId_combobox.Location = new System.Drawing.Point(217, 120);
            this.productId_combobox.Name = "productId_combobox";
            this.productId_combobox.Size = new System.Drawing.Size(43, 21);
            this.productId_combobox.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 114;
            this.label1.Text = "€";
            // 
            // addRelationship_button
            // 
            this.addRelationship_button.ForeColor = System.Drawing.Color.Green;
            this.addRelationship_button.Location = new System.Drawing.Point(185, 238);
            this.addRelationship_button.Name = "addRelationship_button";
            this.addRelationship_button.Size = new System.Drawing.Size(100, 23);
            this.addRelationship_button.TabIndex = 115;
            this.addRelationship_button.Text = "Add Relationship";
            this.addRelationship_button.UseVisualStyleBackColor = true;
            this.addRelationship_button.Click += new System.EventHandler(this.addRelationship_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancel_button.Location = new System.Drawing.Point(72, 238);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 116;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // are_required_label
            // 
            this.are_required_label.AutoSize = true;
            this.are_required_label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.are_required_label.Location = new System.Drawing.Point(140, 9);
            this.are_required_label.Name = "are_required_label";
            this.are_required_label.Size = new System.Drawing.Size(73, 13);
            this.are_required_label.TabIndex = 119;
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
            this.asterix_warning.TabIndex = 118;
            this.asterix_warning.Text = "*";
            // 
            // all_fields_marked_with_label
            // 
            this.all_fields_marked_with_label.AutoSize = true;
            this.all_fields_marked_with_label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.all_fields_marked_with_label.Location = new System.Drawing.Point(12, 9);
            this.all_fields_marked_with_label.Name = "all_fields_marked_with_label";
            this.all_fields_marked_with_label.Size = new System.Drawing.Size(118, 13);
            this.all_fields_marked_with_label.TabIndex = 117;
            this.all_fields_marked_with_label.Text = "All fields marked with";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(45, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 24);
            this.label2.TabIndex = 120;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(45, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 24);
            this.label3.TabIndex = 121;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(45, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 24);
            this.label4.TabIndex = 122;
            this.label4.Text = "*";
            // 
            // NewOrdersProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 303);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.are_required_label);
            this.Controls.Add(this.asterix_warning);
            this.Controls.Add(this.all_fields_marked_with_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.addRelationship_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productId_combobox);
            this.Controls.Add(this.orderId_combobox);
            this.Controls.Add(this.amount_textbox);
            this.Controls.Add(this.amount_label);
            this.Controls.Add(this.idProduct_label);
            this.Controls.Add(this.idOrder_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewOrdersProducts";
            this.Text = "NewOrdersProducts";
            this.Load += new System.EventHandler(this.NewOrdersProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.Label idProduct_label;
        private System.Windows.Forms.Label idOrder_label;
        private System.Windows.Forms.TextBox amount_textbox;
        private System.Windows.Forms.ComboBox orderId_combobox;
        private System.Windows.Forms.ComboBox productId_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addRelationship_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label are_required_label;
        private System.Windows.Forms.Label asterix_warning;
        private System.Windows.Forms.Label all_fields_marked_with_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}