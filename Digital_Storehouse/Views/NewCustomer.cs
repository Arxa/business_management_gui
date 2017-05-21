using Digital_Storehouse.Controllers;
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
        private static Dictionary<String, TextBox> newCustomerTextboxes = new Dictionary<string, TextBox>();
        private BindingNavigator bindingNavigator_Customers;

        public NewCustomer() {
        }

        public NewCustomer(BindingNavigator customersBindingNavigator1)
        {
            bindingNavigator_Customers = customersBindingNavigator1;
            Icon icon = Icon.ExtractAssociatedIcon("C:\\MSSQL\\app.ico");
            this.Icon = icon;

            ViewController.initViewController(this);

            InitializeComponent();

            newCustomerTextboxes["LAST_NAME"] = lastName_textbox;
            newCustomerTextboxes["FIRST_NAME"] = firstName_textbox;
            newCustomerTextboxes["BIRTH_DATE"] = birthDate_textbox;
            newCustomerTextboxes["AGE"] = age_textbox;
            newCustomerTextboxes["AFM"] = afm_textbox;
            newCustomerTextboxes["DOY"] = doy_textbox;
            newCustomerTextboxes["ADDRESS"] = address_textbox;
            newCustomerTextboxes["CITY"] = city_textbox;
            newCustomerTextboxes["PHONE_NUMBER"] = phone_textbox;
            newCustomerTextboxes["PHOTO"] = photo_textbox;
            newCustomerTextboxes["COMMENTS"] = comments_textbox;
        }

        private void addCustomer_button_Click(object sender, EventArgs e)
        {
            ViewController.addNewCustomer(bindingNavigator_Customers);
        }

        private void choosePhoto_button_Click(object sender, EventArgs e)
        {
            ViewController.showPhotoDialogChooser(openFileDialog1, photo_textbox);
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static Dictionary<String, TextBox> getNewCustomerTextboxes()
        {
            return newCustomerTextboxes;
        }

    }
}
