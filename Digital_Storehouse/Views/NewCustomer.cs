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

namespace Digital_Storehouse.Views
{
    public partial class NewCustomer : Form
    {
        private static Dictionary<String, MyTextBox> newCustomerTextboxes = new Dictionary<String, MyTextBox>();
        private BindingNavigator bindingNavigatorCustomers;
        

        public NewCustomer() {
        }

        public NewCustomer(BindingNavigator customersBindingNavigator1)
        {
            bindingNavigatorCustomers = customersBindingNavigator1;

            // Load application icon
            this.Icon = Properties.Resources.app;

            InitializeComponent();

            newCustomerTextboxes["LAST_NAME"] = lastName_textbox;
            newCustomerTextboxes["FIRST_NAME"] = firstName_textbox;
            newCustomerTextboxes["AGE"] = age_textbox;
            newCustomerTextboxes["AFM"] = afm_textbox;
            newCustomerTextboxes["DOY"] = doy_textbox;
            newCustomerTextboxes["ADDRESS"] = address_textbox;
            newCustomerTextboxes["CITY"] = city_textbox;
            newCustomerTextboxes["PHONE_NUMBER"] = phone_textbox;
            newCustomerTextboxes["PHOTO"] = photo_textbox;
            newCustomerTextboxes["COMMENTS"] = comments_textbox;

            NewCustomerController.syncNewCustomerForm(pictureBox1, removePhoto_buton, photo_textbox);
        }

        private void addCustomer_button_Click(object sender, EventArgs e)
        {
            NewCustomerController.AddNewCustomer(newCustomerTextboxes, birthDate_picker.Value.Date, bindingNavigatorCustomers, this);
        }

        private void choosePhoto_button_Click(object sender, EventArgs e)
        {
            NewCustomerController.ShowPhotoDialogChooser(openFileDialog1, photo_textbox);
            pictureBox1.Image = Image.FromFile(photo_textbox.Text);
            NewCustomerController.syncNewCustomerForm(pictureBox1, removePhoto_buton, photo_textbox);
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static Dictionary<String, MyTextBox> GetNewCustomerTextboxes()
        {
            return newCustomerTextboxes;
        }

        private void removePhoto_buton_Click(object sender, EventArgs e)
        {
            NewCustomerController.removePhoto(pictureBox1);
            photo_textbox.Text = Models.Container.EMPTY;
            NewCustomerController.syncNewCustomerForm(pictureBox1, removePhoto_buton, photo_textbox);
        }
    }
}
