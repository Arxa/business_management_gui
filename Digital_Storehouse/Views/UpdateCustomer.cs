using Digital_Storehouse.Controllers;
using Digital_Storehouse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Digital_Storehouse.Daos;

namespace Digital_Storehouse.Views
{
    public partial class UpdateCustomer : Form
    {
        private Dictionary<String, Label> customerValueLabels;
        private static Dictionary<String, MyTextBox> updateCustomerTextboxes = new Dictionary<string, MyTextBox>();

        private BindingNavigator bindingNavigator_Customers;
        private PictureBox pictureBoxCustomer;
        private RichTextBox commentsRichTextBoxCustomer;

        public UpdateCustomer(Dictionary<String, Label> customerValueLabels1, PictureBox pictureBox,
                        RichTextBox commentsRichTextBox1, BindingNavigator customersBindingNavigator1)
        {
            // Load application icon
            this.Icon = Properties.Resources.app;

            bindingNavigator_Customers = customersBindingNavigator1;
            customerValueLabels = customerValueLabels1;
            pictureBoxCustomer = pictureBox;
            commentsRichTextBoxCustomer = commentsRichTextBox1;

            InitializeComponent();

            initializeDictionary();
            initializeFields();   

        }

        

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void updateCustomer_button_Click(object sender, EventArgs e)
        {
            UpdateCustomerController.UpdateCustomer(pictureBox1, updateCustomerTextboxes, customerValueLabels, 
                pictureBoxCustomer, comments_richTextbox, bindingNavigator_Customers, this);   
        }

        private void choosePhoto_button_Click(object sender, EventArgs e)
        {
            UpdateCustomerController.ShowPhotoDialogChooser(openFileDialog1, updateCustomerTextboxes["PHOTO"]);
            UpdateCustomerController.loadPhotoAfterDialog(pictureBox1, photo_textbox.Text);
        }

        // Fields have been edited
        // ----------------------
       

        private void birthDate_picker_ValueChanged(object sender, EventArgs e)
        {
            updateCustomer_button.Enabled = true;
        }
        // ----------------------

        private void removePhotoButton_Click(object sender, EventArgs e)
        {
            UpdateCustomerController.removePhoto(pictureBox1);
            photo_textbox.Text = Models.Container.EMPTY;
        }

        public void initializeDictionary()
        {
            updateCustomerTextboxes["LAST_NAME"] = lastName_textbox;
            updateCustomerTextboxes["FIRST_NAME"] = firstName_textbox;
            updateCustomerTextboxes["AGE"] = age_textbox;
            updateCustomerTextboxes["AFM"] = afm_textbox;
            updateCustomerTextboxes["DOY"] = doy_textbox;
            updateCustomerTextboxes["ADDRESS"] = address_textbox;
            updateCustomerTextboxes["CITY"] = city_textbox;
            updateCustomerTextboxes["PHONE_NUMBER"] = phone_textbox;
            updateCustomerTextboxes["PHOTO"] = photo_textbox;
            
        }

        public void initializeFields()
        {
            lastName_textbox.Text = customerValueLabels["LAST_NAME"].Text;
            firstName_textbox.Text = customerValueLabels["FIRST_NAME"].Text;
            age_textbox.Text = customerValueLabels["AGE"].Text;
            afm_textbox.Text = customerValueLabels["AFM"].Text;
            doy_textbox.Text = customerValueLabels["DOY"].Text;
            address_textbox.Text = customerValueLabels["ADDRESS"].Text;
            city_textbox.Text = customerValueLabels["CITY"].Text;
            phone_textbox.Text = customerValueLabels["PHONE_NUMBER"].Text;
            comments_richTextbox.Text = commentsRichTextBoxCustomer.Text;

            AppDAO.LoadCustomerPhoto(pictureBox1, Int32.Parse(customerValueLabels["CUSTOMER_ID"].Text));
            birthDate_picker.Text = customerValueLabels["BIRTH_DATE"].Text;
        }

        private void lastName_textbox_TextChanged(object sender, EventArgs e)
        {
            updateCustomer_button.Enabled = true;
        }
    }
}
