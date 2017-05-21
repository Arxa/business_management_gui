namespace Digital_Storehouse.Views
{
    partial class UpdateCustomer
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
            this.choosePhoto_button = new System.Windows.Forms.Button();
            this.photo_textbox = new System.Windows.Forms.TextBox();
            this.photo_label = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.addCustomer_button = new System.Windows.Forms.Button();
            this.doy_textbox = new System.Windows.Forms.TextBox();
            this.address_textbox = new System.Windows.Forms.TextBox();
            this.city_textbox = new System.Windows.Forms.TextBox();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.comments_textbox = new System.Windows.Forms.TextBox();
            this.afm_textbox = new System.Windows.Forms.TextBox();
            this.age_textbox = new System.Windows.Forms.TextBox();
            this.birthDate_textbox = new System.Windows.Forms.TextBox();
            this.firstName_textbox = new System.Windows.Forms.TextBox();
            this.lastName_textbox = new System.Windows.Forms.TextBox();
            this.comments_label = new System.Windows.Forms.Label();
            this.city_label = new System.Windows.Forms.Label();
            this.phoneNumber_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.doy_label = new System.Windows.Forms.Label();
            this.afm_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.birthDate_label = new System.Windows.Forms.Label();
            this.firstName_label = new System.Windows.Forms.Label();
            this.lastName_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // choosePhoto_button
            // 
            this.choosePhoto_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.choosePhoto_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.choosePhoto_button.Location = new System.Drawing.Point(210, 260);
            this.choosePhoto_button.Name = "choosePhoto_button";
            this.choosePhoto_button.Size = new System.Drawing.Size(56, 23);
            this.choosePhoto_button.TabIndex = 78;
            this.choosePhoto_button.Text = "Change";
            this.choosePhoto_button.UseVisualStyleBackColor = true;
            // 
            // photo_textbox
            // 
            this.photo_textbox.Cursor = System.Windows.Forms.Cursors.No;
            this.photo_textbox.Location = new System.Drawing.Point(91, 262);
            this.photo_textbox.MaxLength = 100;
            this.photo_textbox.Name = "photo_textbox";
            this.photo_textbox.ReadOnly = true;
            this.photo_textbox.Size = new System.Drawing.Size(100, 20);
            this.photo_textbox.TabIndex = 77;
            this.photo_textbox.TextChanged += new System.EventHandler(this.any_textbox_TextChanged);
            // 
            // photo_label
            // 
            this.photo_label.AutoSize = true;
            this.photo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.photo_label.Location = new System.Drawing.Point(12, 262);
            this.photo_label.Name = "photo_label";
            this.photo_label.Size = new System.Drawing.Size(54, 13);
            this.photo_label.TabIndex = 76;
            this.photo_label.Text = "PHOTO:";
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.Silver;
            this.cancel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cancel_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancel_button.Location = new System.Drawing.Point(511, 346);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(73, 23);
            this.cancel_button.TabIndex = 75;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // addCustomer_button
            // 
            this.addCustomer_button.BackColor = System.Drawing.Color.Silver;
            this.addCustomer_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCustomer_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addCustomer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addCustomer_button.ForeColor = System.Drawing.Color.Green;
            this.addCustomer_button.Location = new System.Drawing.Point(465, 395);
            this.addCustomer_button.Name = "addCustomer_button";
            this.addCustomer_button.Size = new System.Drawing.Size(119, 23);
            this.addCustomer_button.TabIndex = 74;
            this.addCustomer_button.Text = "Update Customer";
            this.addCustomer_button.UseVisualStyleBackColor = false;
            this.addCustomer_button.Click += new System.EventHandler(this.updateCustomer_button_Click);
            // 
            // doy_textbox
            // 
            this.doy_textbox.Location = new System.Drawing.Point(411, 19);
            this.doy_textbox.MaxLength = 40;
            this.doy_textbox.Name = "doy_textbox";
            this.doy_textbox.Size = new System.Drawing.Size(100, 20);
            this.doy_textbox.TabIndex = 73;
            this.doy_textbox.TextChanged += new System.EventHandler(this.any_textbox_TextChanged);
            // 
            // address_textbox
            // 
            this.address_textbox.Location = new System.Drawing.Point(411, 64);
            this.address_textbox.MaxLength = 40;
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.Size = new System.Drawing.Size(100, 20);
            this.address_textbox.TabIndex = 72;
            this.address_textbox.TextChanged += new System.EventHandler(this.any_textbox_TextChanged);
            // 
            // city_textbox
            // 
            this.city_textbox.Location = new System.Drawing.Point(411, 109);
            this.city_textbox.MaxLength = 40;
            this.city_textbox.Name = "city_textbox";
            this.city_textbox.Size = new System.Drawing.Size(100, 20);
            this.city_textbox.TabIndex = 71;
            this.city_textbox.TextChanged += new System.EventHandler(this.any_textbox_TextChanged);
            // 
            // phone_textbox
            // 
            this.phone_textbox.Location = new System.Drawing.Point(411, 152);
            this.phone_textbox.MaxLength = 40;
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(100, 20);
            this.phone_textbox.TabIndex = 70;
            this.phone_textbox.TextChanged += new System.EventHandler(this.any_textbox_TextChanged);
            // 
            // comments_textbox
            // 
            this.comments_textbox.Location = new System.Drawing.Point(411, 199);
            this.comments_textbox.MaxLength = 40;
            this.comments_textbox.Name = "comments_textbox";
            this.comments_textbox.Size = new System.Drawing.Size(100, 20);
            this.comments_textbox.TabIndex = 69;
            this.comments_textbox.TextChanged += new System.EventHandler(this.any_textbox_TextChanged);
            // 
            // afm_textbox
            // 
            this.afm_textbox.Location = new System.Drawing.Point(154, 196);
            this.afm_textbox.MaxLength = 40;
            this.afm_textbox.Name = "afm_textbox";
            this.afm_textbox.Size = new System.Drawing.Size(100, 20);
            this.afm_textbox.TabIndex = 68;
            this.afm_textbox.TextChanged += new System.EventHandler(this.any_textbox_TextChanged);
            // 
            // age_textbox
            // 
            this.age_textbox.Location = new System.Drawing.Point(154, 152);
            this.age_textbox.MaxLength = 3;
            this.age_textbox.Name = "age_textbox";
            this.age_textbox.Size = new System.Drawing.Size(100, 20);
            this.age_textbox.TabIndex = 67;
            this.age_textbox.TextChanged += new System.EventHandler(this.any_textbox_TextChanged);
            // 
            // birthDate_textbox
            // 
            this.birthDate_textbox.Location = new System.Drawing.Point(154, 105);
            this.birthDate_textbox.Name = "birthDate_textbox";
            this.birthDate_textbox.Size = new System.Drawing.Size(100, 20);
            this.birthDate_textbox.TabIndex = 66;
            this.birthDate_textbox.TextChanged += new System.EventHandler(this.any_textbox_TextChanged);
            // 
            // firstName_textbox
            // 
            this.firstName_textbox.Location = new System.Drawing.Point(154, 61);
            this.firstName_textbox.MaxLength = 40;
            this.firstName_textbox.Name = "firstName_textbox";
            this.firstName_textbox.Size = new System.Drawing.Size(100, 20);
            this.firstName_textbox.TabIndex = 65;
            this.firstName_textbox.TextChanged += new System.EventHandler(this.any_textbox_TextChanged);
            // 
            // lastName_textbox
            // 
            this.lastName_textbox.Location = new System.Drawing.Point(154, 12);
            this.lastName_textbox.MaxLength = 40;
            this.lastName_textbox.Name = "lastName_textbox";
            this.lastName_textbox.Size = new System.Drawing.Size(100, 20);
            this.lastName_textbox.TabIndex = 64;
            this.lastName_textbox.TextChanged += new System.EventHandler(this.any_textbox_TextChanged);
            // 
            // comments_label
            // 
            this.comments_label.AutoSize = true;
            this.comments_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comments_label.Location = new System.Drawing.Point(313, 199);
            this.comments_label.Name = "comments_label";
            this.comments_label.Size = new System.Drawing.Size(81, 13);
            this.comments_label.TabIndex = 63;
            this.comments_label.Text = "COMMENTS:";
            // 
            // city_label
            // 
            this.city_label.AutoSize = true;
            this.city_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.city_label.Location = new System.Drawing.Point(313, 112);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(39, 13);
            this.city_label.TabIndex = 62;
            this.city_label.Text = "CITY:";
            // 
            // phoneNumber_label
            // 
            this.phoneNumber_label.AutoSize = true;
            this.phoneNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.phoneNumber_label.Location = new System.Drawing.Point(313, 159);
            this.phoneNumber_label.Name = "phoneNumber_label";
            this.phoneNumber_label.Size = new System.Drawing.Size(54, 13);
            this.phoneNumber_label.TabIndex = 61;
            this.phoneNumber_label.Text = "PHONE:";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.address_label.Location = new System.Drawing.Point(313, 64);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(70, 13);
            this.address_label.TabIndex = 60;
            this.address_label.Text = "ADDRESS:";
            // 
            // doy_label
            // 
            this.doy_label.AutoSize = true;
            this.doy_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.doy_label.Location = new System.Drawing.Point(313, 19);
            this.doy_label.Name = "doy_label";
            this.doy_label.Size = new System.Drawing.Size(37, 13);
            this.doy_label.TabIndex = 59;
            this.doy_label.Text = "DOY:";
            // 
            // afm_label
            // 
            this.afm_label.AutoSize = true;
            this.afm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.afm_label.Location = new System.Drawing.Point(46, 203);
            this.afm_label.Name = "afm_label";
            this.afm_label.Size = new System.Drawing.Size(36, 13);
            this.afm_label.TabIndex = 58;
            this.afm_label.Text = "AFM:";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.age_label.Location = new System.Drawing.Point(46, 159);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(36, 13);
            this.age_label.TabIndex = 57;
            this.age_label.Text = "AGE:";
            // 
            // birthDate_label
            // 
            this.birthDate_label.AutoSize = true;
            this.birthDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.birthDate_label.Location = new System.Drawing.Point(46, 112);
            this.birthDate_label.Name = "birthDate_label";
            this.birthDate_label.Size = new System.Drawing.Size(89, 13);
            this.birthDate_label.TabIndex = 56;
            this.birthDate_label.Text = "BIRTH_DATE:";
            // 
            // firstName_label
            // 
            this.firstName_label.AutoSize = true;
            this.firstName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firstName_label.Location = new System.Drawing.Point(46, 64);
            this.firstName_label.Name = "firstName_label";
            this.firstName_label.Size = new System.Drawing.Size(89, 13);
            this.firstName_label.TabIndex = 55;
            this.firstName_label.Text = "FIRST_NAME:";
            // 
            // lastName_label
            // 
            this.lastName_label.AutoSize = true;
            this.lastName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lastName_label.Location = new System.Drawing.Point(46, 19);
            this.lastName_label.Name = "lastName_label";
            this.lastName_label.Size = new System.Drawing.Size(84, 13);
            this.lastName_label.TabIndex = 54;
            this.lastName_label.Text = "LAST_NAME:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 156);
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 469);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.choosePhoto_button);
            this.Controls.Add(this.photo_textbox);
            this.Controls.Add(this.photo_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.addCustomer_button);
            this.Controls.Add(this.doy_textbox);
            this.Controls.Add(this.address_textbox);
            this.Controls.Add(this.city_textbox);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.comments_textbox);
            this.Controls.Add(this.afm_textbox);
            this.Controls.Add(this.age_textbox);
            this.Controls.Add(this.birthDate_textbox);
            this.Controls.Add(this.firstName_textbox);
            this.Controls.Add(this.lastName_textbox);
            this.Controls.Add(this.comments_label);
            this.Controls.Add(this.city_label);
            this.Controls.Add(this.phoneNumber_label);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.doy_label);
            this.Controls.Add(this.afm_label);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.birthDate_label);
            this.Controls.Add(this.firstName_label);
            this.Controls.Add(this.lastName_label);
            this.Name = "UpdateCustomer";
            this.Text = "UpdateCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choosePhoto_button;
        private System.Windows.Forms.TextBox photo_textbox;
        private System.Windows.Forms.Label photo_label;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button addCustomer_button;
        private System.Windows.Forms.TextBox doy_textbox;
        private System.Windows.Forms.TextBox address_textbox;
        private System.Windows.Forms.TextBox city_textbox;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.TextBox comments_textbox;
        private System.Windows.Forms.TextBox afm_textbox;
        private System.Windows.Forms.TextBox age_textbox;
        private System.Windows.Forms.TextBox birthDate_textbox;
        private System.Windows.Forms.TextBox firstName_textbox;
        private System.Windows.Forms.TextBox lastName_textbox;
        private System.Windows.Forms.Label comments_label;
        private System.Windows.Forms.Label city_label;
        private System.Windows.Forms.Label phoneNumber_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label doy_label;
        private System.Windows.Forms.Label afm_label;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label birthDate_label;
        private System.Windows.Forms.Label firstName_label;
        private System.Windows.Forms.Label lastName_label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}