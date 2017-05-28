namespace Digital_Storehouse.Views
{
    partial class UpdateOrdersProducts
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
            this.amount_textbox = new System.Windows.Forms.TextBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.are_required_label = new System.Windows.Forms.Label();
            this.asterix_warning = new System.Windows.Forms.Label();
            this.all_fields_marked_with_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.amount_label.Location = new System.Drawing.Point(104, 61);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(64, 13);
            this.amount_label.TabIndex = 108;
            this.amount_label.Text = "AMOUNT:";
            // 
            // amount_textbox
            // 
            this.amount_textbox.Location = new System.Drawing.Point(199, 58);
            this.amount_textbox.MaxLength = 10;
            this.amount_textbox.Name = "amount_textbox";
            this.amount_textbox.Size = new System.Drawing.Size(100, 20);
            this.amount_textbox.TabIndex = 109;
            // 
            // cancel_button
            // 
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancel_button.Location = new System.Drawing.Point(93, 133);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 110;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // update_button
            // 
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update_button.ForeColor = System.Drawing.Color.Green;
            this.update_button.Location = new System.Drawing.Point(224, 133);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 111;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // are_required_label
            // 
            this.are_required_label.AutoSize = true;
            this.are_required_label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.are_required_label.Location = new System.Drawing.Point(139, 9);
            this.are_required_label.Name = "are_required_label";
            this.are_required_label.Size = new System.Drawing.Size(73, 13);
            this.are_required_label.TabIndex = 114;
            this.are_required_label.Text = "are required.";
            // 
            // asterix_warning
            // 
            this.asterix_warning.AutoSize = true;
            this.asterix_warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.asterix_warning.ForeColor = System.Drawing.Color.Red;
            this.asterix_warning.Location = new System.Drawing.Point(126, 9);
            this.asterix_warning.Name = "asterix_warning";
            this.asterix_warning.Size = new System.Drawing.Size(18, 24);
            this.asterix_warning.TabIndex = 113;
            this.asterix_warning.Text = "*";
            // 
            // all_fields_marked_with_label
            // 
            this.all_fields_marked_with_label.AutoSize = true;
            this.all_fields_marked_with_label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.all_fields_marked_with_label.Location = new System.Drawing.Point(11, 9);
            this.all_fields_marked_with_label.Name = "all_fields_marked_with_label";
            this.all_fields_marked_with_label.Size = new System.Drawing.Size(118, 13);
            this.all_fields_marked_with_label.TabIndex = 112;
            this.all_fields_marked_with_label.Text = "All fields marked with";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(80, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 24);
            this.label1.TabIndex = 115;
            this.label1.Text = "*";
            // 
            // UpdateOrdersProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 197);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.are_required_label);
            this.Controls.Add(this.asterix_warning);
            this.Controls.Add(this.all_fields_marked_with_label);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.amount_textbox);
            this.Controls.Add(this.amount_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdateOrdersProducts";
            this.Text = "UpdateOrdersProducts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.TextBox amount_textbox;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label are_required_label;
        private System.Windows.Forms.Label asterix_warning;
        private System.Windows.Forms.Label all_fields_marked_with_label;
        private System.Windows.Forms.Label label1;
    }
}