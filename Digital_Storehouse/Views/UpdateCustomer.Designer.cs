using Digital_Storehouse.Models;

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
            this.photo_label = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.updateCustomer_button = new System.Windows.Forms.Button();
            this.comments_label = new System.Windows.Forms.Label();
            this.city_label = new System.Windows.Forms.Label();
            this.phoneNumber_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.doy_label = new System.Windows.Forms.Label();
            this.afm_label = new System.Windows.Forms.Label();
            this.birthDate_label = new System.Windows.Forms.Label();
            this.firstName_label = new System.Windows.Forms.Label();
            this.lastName_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.birthDate_picker = new System.Windows.Forms.DateTimePicker();
            this.are_required_label = new System.Windows.Forms.Label();
            this.asterix_warning = new System.Windows.Forms.Label();
            this.all_fields_marked_with_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.removePhoto_button = new System.Windows.Forms.Button();
            this.lastName_textbox = new Digital_Storehouse.Models.MyTextBox();
            this.firstName_textbox = new Digital_Storehouse.Models.MyTextBox();
            this.afm_textbox = new Digital_Storehouse.Models.MyTextBox();
            this.address_textbox = new Digital_Storehouse.Models.MyTextBox();
            this.doy_textbox = new Digital_Storehouse.Models.MyTextBox();
            this.city_textbox = new Digital_Storehouse.Models.MyTextBox();
            this.phone_textbox = new Digital_Storehouse.Models.MyTextBox();
            this.photo_textbox = new Digital_Storehouse.Models.MyTextBox();
            this.hasPhoto_label = new System.Windows.Forms.Label();
            this.comments_richTextbox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // choosePhoto_button
            // 
            this.choosePhoto_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.choosePhoto_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.choosePhoto_button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosePhoto_button.ForeColor = System.Drawing.Color.Blue;
            this.choosePhoto_button.Location = new System.Drawing.Point(76, 320);
            this.choosePhoto_button.Name = "choosePhoto_button";
            this.choosePhoto_button.Size = new System.Drawing.Size(71, 23);
            this.choosePhoto_button.TabIndex = 78;
            this.choosePhoto_button.Text = "Change";
            this.choosePhoto_button.UseVisualStyleBackColor = true;
            this.choosePhoto_button.Click += new System.EventHandler(this.choosePhoto_button_Click);
            // 
            // photo_label
            // 
            this.photo_label.AutoSize = true;
            this.photo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.photo_label.Location = new System.Drawing.Point(31, 362);
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
            this.cancel_button.Location = new System.Drawing.Point(450, 498);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(73, 23);
            this.cancel_button.TabIndex = 75;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // updateCustomer_button
            // 
            this.updateCustomer_button.BackColor = System.Drawing.Color.Silver;
            this.updateCustomer_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateCustomer_button.Enabled = false;
            this.updateCustomer_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateCustomer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.updateCustomer_button.ForeColor = System.Drawing.Color.Green;
            this.updateCustomer_button.Location = new System.Drawing.Point(404, 547);
            this.updateCustomer_button.Name = "updateCustomer_button";
            this.updateCustomer_button.Size = new System.Drawing.Size(119, 23);
            this.updateCustomer_button.TabIndex = 74;
            this.updateCustomer_button.Text = "Update Customer";
            this.updateCustomer_button.UseVisualStyleBackColor = false;
            this.updateCustomer_button.Click += new System.EventHandler(this.updateCustomer_button_Click);
            // 
            // comments_label
            // 
            this.comments_label.AutoSize = true;
            this.comments_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comments_label.Location = new System.Drawing.Point(317, 281);
            this.comments_label.Name = "comments_label";
            this.comments_label.Size = new System.Drawing.Size(81, 13);
            this.comments_label.TabIndex = 63;
            this.comments_label.Text = "COMMENTS:";
            // 
            // city_label
            // 
            this.city_label.AutoSize = true;
            this.city_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.city_label.Location = new System.Drawing.Point(317, 187);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(39, 13);
            this.city_label.TabIndex = 62;
            this.city_label.Text = "CITY:";
            // 
            // phoneNumber_label
            // 
            this.phoneNumber_label.AutoSize = true;
            this.phoneNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.phoneNumber_label.Location = new System.Drawing.Point(317, 234);
            this.phoneNumber_label.Name = "phoneNumber_label";
            this.phoneNumber_label.Size = new System.Drawing.Size(54, 13);
            this.phoneNumber_label.TabIndex = 61;
            this.phoneNumber_label.Text = "PHONE:";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.address_label.Location = new System.Drawing.Point(317, 139);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(70, 13);
            this.address_label.TabIndex = 60;
            this.address_label.Text = "ADDRESS:";
            // 
            // doy_label
            // 
            this.doy_label.AutoSize = true;
            this.doy_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.doy_label.Location = new System.Drawing.Point(317, 94);
            this.doy_label.Name = "doy_label";
            this.doy_label.Size = new System.Drawing.Size(37, 13);
            this.doy_label.TabIndex = 59;
            this.doy_label.Text = "DOY:";
            // 
            // afm_label
            // 
            this.afm_label.AutoSize = true;
            this.afm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.afm_label.Location = new System.Drawing.Point(33, 231);
            this.afm_label.Name = "afm_label";
            this.afm_label.Size = new System.Drawing.Size(36, 13);
            this.afm_label.TabIndex = 58;
            this.afm_label.Text = "AFM:";
            // 
            // birthDate_label
            // 
            this.birthDate_label.AutoSize = true;
            this.birthDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.birthDate_label.Location = new System.Drawing.Point(33, 187);
            this.birthDate_label.Name = "birthDate_label";
            this.birthDate_label.Size = new System.Drawing.Size(89, 13);
            this.birthDate_label.TabIndex = 56;
            this.birthDate_label.Text = "BIRTH_DATE:";
            // 
            // firstName_label
            // 
            this.firstName_label.AutoSize = true;
            this.firstName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firstName_label.Location = new System.Drawing.Point(33, 139);
            this.firstName_label.Name = "firstName_label";
            this.firstName_label.Size = new System.Drawing.Size(89, 13);
            this.firstName_label.TabIndex = 55;
            this.firstName_label.Text = "FIRST_NAME:";
            // 
            // lastName_label
            // 
            this.lastName_label.AutoSize = true;
            this.lastName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lastName_label.Location = new System.Drawing.Point(33, 94);
            this.lastName_label.Name = "lastName_label";
            this.lastName_label.Size = new System.Drawing.Size(84, 13);
            this.lastName_label.TabIndex = 54;
            this.lastName_label.Text = "LAST_NAME:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 392);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 230);
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // birthDate_picker
            // 
            this.birthDate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDate_picker.Location = new System.Drawing.Point(134, 181);
            this.birthDate_picker.Name = "birthDate_picker";
            this.birthDate_picker.Size = new System.Drawing.Size(108, 20);
            this.birthDate_picker.TabIndex = 80;
            this.birthDate_picker.Value = new System.DateTime(1994, 10, 31, 0, 0, 0, 0);
            this.birthDate_picker.ValueChanged += new System.EventHandler(this.birthDate_picker_ValueChanged);
            // 
            // are_required_label
            // 
            this.are_required_label.AutoSize = true;
            this.are_required_label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.are_required_label.Location = new System.Drawing.Point(161, 20);
            this.are_required_label.Name = "are_required_label";
            this.are_required_label.Size = new System.Drawing.Size(73, 13);
            this.are_required_label.TabIndex = 83;
            this.are_required_label.Text = "are required.";
            // 
            // asterix_warning
            // 
            this.asterix_warning.AutoSize = true;
            this.asterix_warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.asterix_warning.ForeColor = System.Drawing.Color.Red;
            this.asterix_warning.Location = new System.Drawing.Point(148, 20);
            this.asterix_warning.Name = "asterix_warning";
            this.asterix_warning.Size = new System.Drawing.Size(18, 24);
            this.asterix_warning.TabIndex = 82;
            this.asterix_warning.Text = "*";
            // 
            // all_fields_marked_with_label
            // 
            this.all_fields_marked_with_label.AutoSize = true;
            this.all_fields_marked_with_label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.all_fields_marked_with_label.Location = new System.Drawing.Point(33, 20);
            this.all_fields_marked_with_label.Name = "all_fields_marked_with_label";
            this.all_fields_marked_with_label.Size = new System.Drawing.Size(118, 13);
            this.all_fields_marked_with_label.TabIndex = 81;
            this.all_fields_marked_with_label.Text = "All fields marked with";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 24);
            this.label1.TabIndex = 84;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(9, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 24);
            this.label2.TabIndex = 85;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(9, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 24);
            this.label3.TabIndex = 86;
            this.label3.Text = "*";
            // 
            // removePhoto_button
            // 
            this.removePhoto_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removePhoto_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removePhoto_button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removePhoto_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.removePhoto_button.Location = new System.Drawing.Point(163, 320);
            this.removePhoto_button.Name = "removePhoto_button";
            this.removePhoto_button.Size = new System.Drawing.Size(71, 23);
            this.removePhoto_button.TabIndex = 87;
            this.removePhoto_button.Text = "Remove";
            this.removePhoto_button.UseVisualStyleBackColor = true;
            this.removePhoto_button.Click += new System.EventHandler(this.removePhotoButton_Click);
            // 
            // lastName_textbox
            // 
            this.lastName_textbox.Location = new System.Drawing.Point(134, 92);
            this.lastName_textbox.MaxLength = 20;
            this.lastName_textbox.Name = "lastName_textbox";
            this.lastName_textbox.Size = new System.Drawing.Size(108, 20);
            this.lastName_textbox.TabIndex = 88;
            this.lastName_textbox.TextChanged += new System.EventHandler(this.lastName_textbox_TextChanged);
            // 
            // firstName_textbox
            // 
            this.firstName_textbox.Location = new System.Drawing.Point(134, 136);
            this.firstName_textbox.MaxLength = 20;
            this.firstName_textbox.Name = "firstName_textbox";
            this.firstName_textbox.Size = new System.Drawing.Size(108, 20);
            this.firstName_textbox.TabIndex = 89;
            this.firstName_textbox.TextChanged += new System.EventHandler(this.lastName_textbox_TextChanged);
            // 
            // afm_textbox
            // 
            this.afm_textbox.Location = new System.Drawing.Point(134, 231);
            this.afm_textbox.MaxLength = 9;
            this.afm_textbox.Name = "afm_textbox";
            this.afm_textbox.Size = new System.Drawing.Size(108, 20);
            this.afm_textbox.TabIndex = 91;
            this.afm_textbox.TextChanged += new System.EventHandler(this.lastName_textbox_TextChanged);
            // 
            // address_textbox
            // 
            this.address_textbox.Location = new System.Drawing.Point(415, 139);
            this.address_textbox.MaxLength = 50;
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.Size = new System.Drawing.Size(108, 20);
            this.address_textbox.TabIndex = 92;
            this.address_textbox.TextChanged += new System.EventHandler(this.lastName_textbox_TextChanged);
            // 
            // doy_textbox
            // 
            this.doy_textbox.Location = new System.Drawing.Point(415, 91);
            this.doy_textbox.MaxLength = 50;
            this.doy_textbox.Name = "doy_textbox";
            this.doy_textbox.Size = new System.Drawing.Size(108, 20);
            this.doy_textbox.TabIndex = 93;
            this.doy_textbox.TextChanged += new System.EventHandler(this.lastName_textbox_TextChanged);
            // 
            // city_textbox
            // 
            this.city_textbox.Location = new System.Drawing.Point(415, 180);
            this.city_textbox.MaxLength = 50;
            this.city_textbox.Name = "city_textbox";
            this.city_textbox.Size = new System.Drawing.Size(108, 20);
            this.city_textbox.TabIndex = 94;
            this.city_textbox.TextChanged += new System.EventHandler(this.lastName_textbox_TextChanged);
            // 
            // phone_textbox
            // 
            this.phone_textbox.Location = new System.Drawing.Point(415, 227);
            this.phone_textbox.MaxLength = 10;
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(108, 20);
            this.phone_textbox.TabIndex = 95;
            this.phone_textbox.TextChanged += new System.EventHandler(this.lastName_textbox_TextChanged);
            // 
            // photo_textbox
            // 
            this.photo_textbox.Enabled = false;
            this.photo_textbox.Location = new System.Drawing.Point(105, 359);
            this.photo_textbox.Name = "photo_textbox";
            this.photo_textbox.Size = new System.Drawing.Size(100, 20);
            this.photo_textbox.TabIndex = 97;
            this.photo_textbox.TextChanged += new System.EventHandler(this.lastName_textbox_TextChanged);
            // 
            // hasPhoto_label
            // 
            this.hasPhoto_label.AutoSize = true;
            this.hasPhoto_label.ForeColor = System.Drawing.SystemColors.Menu;
            this.hasPhoto_label.Location = new System.Drawing.Point(457, 20);
            this.hasPhoto_label.Name = "hasPhoto_label";
            this.hasPhoto_label.Size = new System.Drawing.Size(35, 13);
            this.hasPhoto_label.TabIndex = 98;
            this.hasPhoto_label.Text = "label4";
            // 
            // comments_richTextbox
            // 
            this.comments_richTextbox.BackColor = System.Drawing.SystemColors.Menu;
            this.comments_richTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comments_richTextbox.Location = new System.Drawing.Point(320, 306);
            this.comments_richTextbox.MaxLength = 500;
            this.comments_richTextbox.Name = "comments_richTextbox";
            this.comments_richTextbox.Size = new System.Drawing.Size(203, 73);
            this.comments_richTextbox.TabIndex = 99;
            this.comments_richTextbox.Text = "";
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 643);
            this.Controls.Add(this.comments_richTextbox);
            this.Controls.Add(this.hasPhoto_label);
            this.Controls.Add(this.photo_textbox);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.city_textbox);
            this.Controls.Add(this.doy_textbox);
            this.Controls.Add(this.address_textbox);
            this.Controls.Add(this.afm_textbox);
            this.Controls.Add(this.firstName_textbox);
            this.Controls.Add(this.lastName_textbox);
            this.Controls.Add(this.removePhoto_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.are_required_label);
            this.Controls.Add(this.asterix_warning);
            this.Controls.Add(this.all_fields_marked_with_label);
            this.Controls.Add(this.birthDate_picker);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.choosePhoto_button);
            this.Controls.Add(this.photo_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.updateCustomer_button);
            this.Controls.Add(this.comments_label);
            this.Controls.Add(this.city_label);
            this.Controls.Add(this.phoneNumber_label);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.doy_label);
            this.Controls.Add(this.afm_label);
            this.Controls.Add(this.birthDate_label);
            this.Controls.Add(this.firstName_label);
            this.Controls.Add(this.lastName_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdateCustomer";
            this.Text = "UpdateCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button choosePhoto_button;
        private System.Windows.Forms.Label photo_label;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button updateCustomer_button;

        private System.Windows.Forms.Label comments_label;
        private System.Windows.Forms.Label city_label;
        private System.Windows.Forms.Label phoneNumber_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label doy_label;
        private System.Windows.Forms.Label afm_label;
        private System.Windows.Forms.Label birthDate_label;
        private System.Windows.Forms.Label firstName_label;
        private System.Windows.Forms.Label lastName_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker birthDate_picker;
        private System.Windows.Forms.Label are_required_label;
        private System.Windows.Forms.Label asterix_warning;
        private System.Windows.Forms.Label all_fields_marked_with_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removePhoto_button;
        private MyTextBox lastName_textbox;
        private MyTextBox firstName_textbox;
        private MyTextBox afm_textbox;
        private MyTextBox address_textbox;
        private MyTextBox doy_textbox;
        private MyTextBox city_textbox;
        private MyTextBox phone_textbox;
        private MyTextBox photo_textbox;
        private System.Windows.Forms.Label hasPhoto_label;
        private System.Windows.Forms.RichTextBox comments_richTextbox;
    }


}