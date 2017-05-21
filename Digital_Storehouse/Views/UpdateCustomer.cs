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
    public partial class UpdateCustomer : Form
    {
        private Dictionary<String, Label> customerValueLabels;
        private static Dictionary<String, TextBox> updateCustomerTextboxes = new Dictionary<string, TextBox>();
        private BindingNavigator bindingNavigator_Customers;

        public UpdateCustomer(Dictionary<String, Label> customerValueLabels1, BindingNavigator customersBindingNavigator1)
        {
            bindingNavigator_Customers = customersBindingNavigator1;
            customerValueLabels = customerValueLabels1;

            InitializeComponent();

            initializeFields();

            // Initialize Dictionary
            updateCustomerTextboxes["LAST_NAME"] = lastName_textbox;
            updateCustomerTextboxes["FIRST_NAME"] = firstName_textbox;
            updateCustomerTextboxes["BIRTH_DATE"] = birthDate_textbox;
            updateCustomerTextboxes["AGE"] = age_textbox;
            updateCustomerTextboxes["AFM"] = afm_textbox;
            updateCustomerTextboxes["DOY"] = doy_textbox;
            updateCustomerTextboxes["ADDRESS"] = address_textbox;
            updateCustomerTextboxes["CITY"] = city_textbox;
            updateCustomerTextboxes["PHONE_NUMBER"] = phone_textbox;
            updateCustomerTextboxes["COMMENTS"] = comments_textbox;
        }

        public void initializeFields()
        {
            lastName_textbox.Text = customerValueLabels["LAST_NAME"].Text;
            firstName_textbox.Text = customerValueLabels["FIRST_NAME"].Text;
            birthDate_textbox.Text = customerValueLabels["BIRTH_DATE"].Text;
            age_textbox.Text = customerValueLabels["AGE"].Text;
            afm_textbox.Text = customerValueLabels["AFM"].Text;
            doy_textbox.Text = customerValueLabels["DOY"].Text;
            address_textbox.Text = customerValueLabels["ADDRESS"].Text;
            city_textbox.Text = customerValueLabels["CITY"].Text;
            phone_textbox.Text = customerValueLabels["PHONE_NUMBER"].Text;
            comments_textbox.Text = customerValueLabels["COMMENTS"].Text;
            DatabaseController.loadCustomerPhoto(pictureBox1);

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void any_textbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void updateCustomer_button_Click(object sender, EventArgs e)
        {
            ViewController.updateCustomer(updateCustomerTextboxes, customerValueLabels["CUSTOMER_ID"].Text, bindingNavigator_Customers);   
        }
    }
}
