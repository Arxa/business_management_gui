using Digital_Storehouse.Models;

namespace Digital_Storehouse.Views
{
    partial class NewCustomer
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
            this.addCustomer_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.photo_label = new System.Windows.Forms.Label();
            this.choosePhoto_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.birthDate_picker = new System.Windows.Forms.DateTimePicker();
            this.asterix_lastName = new System.Windows.Forms.Label();
            this.asterix_firstName = new System.Windows.Forms.Label();
            this.asterix_afm = new System.Windows.Forms.Label();
            this.all_fields_marked_with_label = new System.Windows.Forms.Label();
            this.asterix_warning = new System.Windows.Forms.Label();
            this.are_required_label = new System.Windows.Forms.Label();
            this.lastName_textbox = new Digital_Storehouse.Models.MyTextBox();
            this.firstName_textbox = new Digital_Storehouse.Models.MyTextBox();
            this.age_textbox = new Digital_Storehouse.Models.MyTextBox();
            this.afm_textbox = new Digital_Storehouse.Models.MyTextBox();
            this.doy_textbox = new Digital_Storehouse.Models.MyTextBox();
            this.address_textbox = new Digital_Storehouse.Models.MyTextBox();
            this.phone_textbox = new Digital_Storehouse.Models.MyTextBox();
            this.city_textbox = new Digital_Storehouse.Models.MyTextBox();
            this.photo_textbox = new Digital_Storehouse.Models.MyTextBox();
            this.removePhoto_buton = new System.Windows.Forms.Button();
            this.comments_richTextbox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comments_label
            // 
            this.comments_label.AutoSize = true;
            this.comments_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comments_label.Location = new System.Drawing.Point(319, 263);
            this.comments_label.Name = "comments_label";
            this.comments_label.Size = new System.Drawing.Size(81, 13);
            this.comments_label.TabIndex = 38;
            this.comments_label.Text = "COMMENTS:";
            // 
            // city_label
            // 
            this.city_label.AutoSize = true;
            this.city_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.city_label.Location = new System.Drawing.Point(319, 167);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(39, 13);
            this.city_label.TabIndex = 36;
            this.city_label.Text = "CITY:";
            // 
            // phoneNumber_label
            // 
            this.phoneNumber_label.AutoSize = true;
            this.phoneNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.phoneNumber_label.Location = new System.Drawing.Point(319, 215);
            this.phoneNumber_label.Name = "phoneNumber_label";
            this.phoneNumber_label.Size = new System.Drawing.Size(54, 13);
            this.phoneNumber_label.TabIndex = 35;
            this.phoneNumber_label.Text = "PHONE:";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.address_label.Location = new System.Drawing.Point(319, 124);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(70, 13);
            this.address_label.TabIndex = 34;
            this.address_label.Text = "ADDRESS:";
            // 
            // doy_label
            // 
            this.doy_label.AutoSize = true;
            this.doy_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.doy_label.Location = new System.Drawing.Point(319, 75);
            this.doy_label.Name = "doy_label";
            this.doy_label.Size = new System.Drawing.Size(37, 13);
            this.doy_label.TabIndex = 33;
            this.doy_label.Text = "DOY:";
            // 
            // afm_label
            // 
            this.afm_label.AutoSize = true;
            this.afm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.afm_label.Location = new System.Drawing.Point(44, 263);
            this.afm_label.Name = "afm_label";
            this.afm_label.Size = new System.Drawing.Size(36, 13);
            this.afm_label.TabIndex = 32;
            this.afm_label.Text = "AFM:";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.age_label.Location = new System.Drawing.Point(44, 215);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(36, 13);
            this.age_label.TabIndex = 31;
            this.age_label.Text = "AGE:";
            // 
            // birthDate_label
            // 
            this.birthDate_label.AutoSize = true;
            this.birthDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.birthDate_label.Location = new System.Drawing.Point(44, 167);
            this.birthDate_label.Name = "birthDate_label";
            this.birthDate_label.Size = new System.Drawing.Size(89, 13);
            this.birthDate_label.TabIndex = 30;
            this.birthDate_label.Text = "BIRTH_DATE:";
            // 
            // firstName_label
            // 
            this.firstName_label.AutoSize = true;
            this.firstName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firstName_label.Location = new System.Drawing.Point(44, 124);
            this.firstName_label.Name = "firstName_label";
            this.firstName_label.Size = new System.Drawing.Size(89, 13);
            this.firstName_label.TabIndex = 29;
            this.firstName_label.Text = "FIRST_NAME:";
            // 
            // lastName_label
            // 
            this.lastName_label.AutoSize = true;
            this.lastName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lastName_label.Location = new System.Drawing.Point(44, 79);
            this.lastName_label.Name = "lastName_label";
            this.lastName_label.Size = new System.Drawing.Size(84, 13);
            this.lastName_label.TabIndex = 28;
            this.lastName_label.Text = "LAST_NAME:";
            // 
            // addCustomer_button
            // 
            this.addCustomer_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCustomer_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCustomer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addCustomer_button.Location = new System.Drawing.Point(406, 542);
            this.addCustomer_button.Name = "addCustomer_button";
            this.addCustomer_button.Size = new System.Drawing.Size(99, 23);
            this.addCustomer_button.TabIndex = 49;
            this.addCustomer_button.Text = "Add Customer";
            this.addCustomer_button.UseVisualStyleBackColor = false;
            this.addCustomer_button.Click += new System.EventHandler(this.addCustomer_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.Red;
            this.cancel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cancel_button.Location = new System.Drawing.Point(430, 481);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 50;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // photo_label
            // 
            this.photo_label.AutoSize = true;
            this.photo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.photo_label.Location = new System.Drawing.Point(37, 415);
            this.photo_label.Name = "photo_label";
            this.photo_label.Size = new System.Drawing.Size(54, 13);
            this.photo_label.TabIndex = 51;
            this.photo_label.Text = "PHOTO:";
            // 
            // choosePhoto_button
            // 
            this.choosePhoto_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.choosePhoto_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.choosePhoto_button.Location = new System.Drawing.Point(229, 410);
            this.choosePhoto_button.Name = "choosePhoto_button";
            this.choosePhoto_button.Size = new System.Drawing.Size(99, 23);
            this.choosePhoto_button.TabIndex = 53;
            this.choosePhoto_button.Text = "Choose Photo";
            this.choosePhoto_button.UseVisualStyleBackColor = true;
            this.choosePhoto_button.Click += new System.EventHandler(this.choosePhoto_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(42, 452);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 230);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // birthDate_picker
            // 
            this.birthDate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDate_picker.Location = new System.Drawing.Point(149, 164);
            this.birthDate_picker.Name = "birthDate_picker";
            this.birthDate_picker.Size = new System.Drawing.Size(100, 20);
            this.birthDate_picker.TabIndex = 55;
            this.birthDate_picker.Value = new System.DateTime(2017, 5, 24, 17, 42, 42, 0);
            // 
            // asterix_lastName
            // 
            this.asterix_lastName.AutoSize = true;
            this.asterix_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.asterix_lastName.ForeColor = System.Drawing.Color.Red;
            this.asterix_lastName.Location = new System.Drawing.Point(20, 75);
            this.asterix_lastName.Name = "asterix_lastName";
            this.asterix_lastName.Size = new System.Drawing.Size(18, 24);
            this.asterix_lastName.TabIndex = 56;
            this.asterix_lastName.Text = "*";
            // 
            // asterix_firstName
            // 
            this.asterix_firstName.AutoSize = true;
            this.asterix_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.asterix_firstName.ForeColor = System.Drawing.Color.Red;
            this.asterix_firstName.Location = new System.Drawing.Point(20, 121);
            this.asterix_firstName.Name = "asterix_firstName";
            this.asterix_firstName.Size = new System.Drawing.Size(18, 24);
            this.asterix_firstName.TabIndex = 57;
            this.asterix_firstName.Text = "*";
            // 
            // asterix_afm
            // 
            this.asterix_afm.AutoSize = true;
            this.asterix_afm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.asterix_afm.ForeColor = System.Drawing.Color.Red;
            this.asterix_afm.Location = new System.Drawing.Point(20, 256);
            this.asterix_afm.Name = "asterix_afm";
            this.asterix_afm.Size = new System.Drawing.Size(18, 24);
            this.asterix_afm.TabIndex = 60;
            this.asterix_afm.Text = "*";
            // 
            // all_fields_marked_with_label
            // 
            this.all_fields_marked_with_label.AutoSize = true;
            this.all_fields_marked_with_label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.all_fields_marked_with_label.Location = new System.Drawing.Point(18, 18);
            this.all_fields_marked_with_label.Name = "all_fields_marked_with_label";
            this.all_fields_marked_with_label.Size = new System.Drawing.Size(118, 13);
            this.all_fields_marked_with_label.TabIndex = 62;
            this.all_fields_marked_with_label.Text = "All fields marked with";
            // 
            // asterix_warning
            // 
            this.asterix_warning.AutoSize = true;
            this.asterix_warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.asterix_warning.ForeColor = System.Drawing.Color.Red;
            this.asterix_warning.Location = new System.Drawing.Point(133, 18);
            this.asterix_warning.Name = "asterix_warning";
            this.asterix_warning.Size = new System.Drawing.Size(18, 24);
            this.asterix_warning.TabIndex = 63;
            this.asterix_warning.Text = "*";
            // 
            // are_required_label
            // 
            this.are_required_label.AutoSize = true;
            this.are_required_label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.are_required_label.Location = new System.Drawing.Point(146, 18);
            this.are_required_label.Name = "are_required_label";
            this.are_required_label.Size = new System.Drawing.Size(73, 13);
            this.are_required_label.TabIndex = 64;
            this.are_required_label.Text = "are required.";
            // 
            // lastName_textbox
            // 
            this.lastName_textbox.Location = new System.Drawing.Point(149, 75);
            this.lastName_textbox.MaxLength = 20;
            this.lastName_textbox.Name = "lastName_textbox";
            this.lastName_textbox.Size = new System.Drawing.Size(100, 20);
            this.lastName_textbox.TabIndex = 65;
            // 
            // firstName_textbox
            // 
            this.firstName_textbox.Location = new System.Drawing.Point(149, 121);
            this.firstName_textbox.MaxLength = 20;
            this.firstName_textbox.Name = "firstName_textbox";
            this.firstName_textbox.Size = new System.Drawing.Size(100, 20);
            this.firstName_textbox.TabIndex = 66;
            // 
            // age_textbox
            // 
            this.age_textbox.Location = new System.Drawing.Point(149, 212);
            this.age_textbox.MaxLength = 3;
            this.age_textbox.Name = "age_textbox";
            this.age_textbox.Size = new System.Drawing.Size(100, 20);
            this.age_textbox.TabIndex = 67;
            // 
            // afm_textbox
            // 
            this.afm_textbox.Location = new System.Drawing.Point(149, 260);
            this.afm_textbox.MaxLength = 9;
            this.afm_textbox.Name = "afm_textbox";
            this.afm_textbox.Size = new System.Drawing.Size(100, 20);
            this.afm_textbox.TabIndex = 68;
            // 
            // doy_textbox
            // 
            this.doy_textbox.Location = new System.Drawing.Point(416, 76);
            this.doy_textbox.MaxLength = 50;
            this.doy_textbox.Name = "doy_textbox";
            this.doy_textbox.Size = new System.Drawing.Size(100, 20);
            this.doy_textbox.TabIndex = 69;
            // 
            // address_textbox
            // 
            this.address_textbox.Location = new System.Drawing.Point(416, 117);
            this.address_textbox.MaxLength = 50;
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.Size = new System.Drawing.Size(100, 20);
            this.address_textbox.TabIndex = 70;
            // 
            // phone_textbox
            // 
            this.phone_textbox.Location = new System.Drawing.Point(416, 208);
            this.phone_textbox.MaxLength = 10;
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(100, 20);
            this.phone_textbox.TabIndex = 71;
            // 
            // city_textbox
            // 
            this.city_textbox.Location = new System.Drawing.Point(416, 164);
            this.city_textbox.MaxLength = 50;
            this.city_textbox.Name = "city_textbox";
            this.city_textbox.Size = new System.Drawing.Size(100, 20);
            this.city_textbox.TabIndex = 72;
            // 
            // photo_textbox
            // 
            this.photo_textbox.Enabled = false;
            this.photo_textbox.Location = new System.Drawing.Point(108, 412);
            this.photo_textbox.MaxLength = 50;
            this.photo_textbox.Name = "photo_textbox";
            this.photo_textbox.Size = new System.Drawing.Size(100, 20);
            this.photo_textbox.TabIndex = 74;
            // 
            // removePhoto_buton
            // 
            this.removePhoto_buton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removePhoto_buton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removePhoto_buton.Location = new System.Drawing.Point(346, 409);
            this.removePhoto_buton.Name = "removePhoto_buton";
            this.removePhoto_buton.Size = new System.Drawing.Size(75, 23);
            this.removePhoto_buton.TabIndex = 75;
            this.removePhoto_buton.Text = "Remove";
            this.removePhoto_buton.UseVisualStyleBackColor = true;
            this.removePhoto_buton.Click += new System.EventHandler(this.removePhoto_buton_Click);
            // 
            // comments_richTextbox
            // 
            this.comments_richTextbox.BackColor = System.Drawing.SystemColors.Menu;
            this.comments_richTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comments_richTextbox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comments_richTextbox.Location = new System.Drawing.Point(322, 293);
            this.comments_richTextbox.MaxLength = 500;
            this.comments_richTextbox.Name = "comments_richTextbox";
            this.comments_richTextbox.Size = new System.Drawing.Size(234, 72);
            this.comments_richTextbox.TabIndex = 76;
            this.comments_richTextbox.Text = "";
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(568, 694);
            this.Controls.Add(this.comments_richTextbox);
            this.Controls.Add(this.removePhoto_buton);
            this.Controls.Add(this.photo_textbox);
            this.Controls.Add(this.city_textbox);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.address_textbox);
            this.Controls.Add(this.doy_textbox);
            this.Controls.Add(this.afm_textbox);
            this.Controls.Add(this.age_textbox);
            this.Controls.Add(this.firstName_textbox);
            this.Controls.Add(this.lastName_textbox);
            this.Controls.Add(this.are_required_label);
            this.Controls.Add(this.asterix_warning);
            this.Controls.Add(this.all_fields_marked_with_label);
            this.Controls.Add(this.asterix_afm);
            this.Controls.Add(this.asterix_firstName);
            this.Controls.Add(this.asterix_lastName);
            this.Controls.Add(this.birthDate_picker);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.choosePhoto_button);
            this.Controls.Add(this.photo_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.addCustomer_button);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewCustomer";
            this.Text = "Add New Customer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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



        private System.Windows.Forms.Button addCustomer_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label photo_label;
        private System.Windows.Forms.Button choosePhoto_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker birthDate_picker;
        private System.Windows.Forms.Label asterix_lastName;
        private System.Windows.Forms.Label asterix_firstName;
        private System.Windows.Forms.Label asterix_afm;
        private System.Windows.Forms.Label all_fields_marked_with_label;
        private System.Windows.Forms.Label asterix_warning;
        private System.Windows.Forms.Label are_required_label;
        private MyTextBox lastName_textbox;
        private MyTextBox firstName_textbox;
        private MyTextBox age_textbox;
        private MyTextBox afm_textbox;
        private MyTextBox doy_textbox;
        private MyTextBox address_textbox;
        private MyTextBox phone_textbox;
        private MyTextBox city_textbox;
        private MyTextBox photo_textbox;
        private System.Windows.Forms.Button removePhoto_buton;
        private System.Windows.Forms.RichTextBox comments_richTextbox;
    }
}