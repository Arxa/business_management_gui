using Digital_Storehouse.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Storehouse.Controllers
{
    class ViewController
    {
        private static App appForm;
        private static NewCustomer newCustomerForm;

        public static void initViewController(NewCustomer newCustomerForm1) {
            newCustomerForm = newCustomerForm1;
        }

        public static void initViewController(App appForm1) {
            appForm = appForm1;
        }

        public static void initViewController(NewCustomer newCustomerForm1, App appForm1) {
            newCustomerForm = newCustomerForm1;
            appForm = appForm1;
        }

        public static bool validateFields(Dictionary<String, TextBox> newCustomerTextboxes)
        {
            foreach (KeyValuePair<String, TextBox> entry in newCustomerTextboxes)
            {
                if (entry.Value.Text.Equals(""))
                {
                    MessageBox.Show("Please fill in all the fields",
                    "Field(s) are empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            // Check for valid file Path
            bool valid = true;
            System.IO.FileInfo fi = null;

            /*try {
                fi = new System.IO.FileInfo(newCustomerTextboxes["PHOTO"].Text.Trim());
            }
            catch (ArgumentException) { valid = false; }
            catch (System.IO.PathTooLongException) { valid = false; }
            catch (NotSupportedException) { valid = false; }

            if (ReferenceEquals(fi, null)) {
                valid = false;
            }
            
            if (!valid) {
                MessageBox.Show("Please use a valid path for your image",
                    "File Path format not supported", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }*/

            
            // Check for image size
            /*
            if (newCustomerTextboxes["PHOTO"].Text.Trim().Length > 256000)
            {
                MessageBox.Show("Your chosen image exceeds the size limit. Please modify your image and try again.",
                    "File is too large", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }*/


            // Check for AGE input
            if (! int.TryParse(newCustomerTextboxes["AGE"].Text.Trim(), out int n))
            {
                MessageBox.Show("Please use a valid integer number for the 'AGE' field.",
                    "Unaccepted input value for 'AGE' field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            // Check for AFM input
            if (!int.TryParse(newCustomerTextboxes["AFM"].Text.Trim(), out n))
            {
                MessageBox.Show("Please use a valid integer number for the 'AFM' field.",
                    "Unaccepted input value for 'AFM' field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static void deleteCustomer(Dictionary<String, Label> customerValueLabels, BindingNavigator bindingNavigator_Customer)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Customer?",
                "Deleting Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            DatabaseController.deleteCustomer(customerValueLabels["CUSTOMER_ID"].Text);
            foreach (KeyValuePair<String, Label> entry in App.getCustomerValueLabels())
            {
                entry.Value.DataBindings.Clear();
            }
            DatabaseController.BindCustomerData(customerValueLabels, bindingNavigator_Customer);
        }

        public static void openNewCustomerForm(BindingNavigator bindingNavigator_Customer)
        {
            NewCustomer form = new NewCustomer(bindingNavigator_Customer);
            form.Show();
        }

        public static void addNewCustomer(BindingNavigator bindingNavigator_Customers)
        {
            if (! validateFields(NewCustomer.getNewCustomerTextboxes())) {
                return;
            }

            // Refresh the Binding Navigator if customer was added succesfully
            try {
                DatabaseController.addNewCustomer(NewCustomer.getNewCustomerTextboxes());
                foreach (KeyValuePair<String, Label> entry in App.getCustomerValueLabels()) {
                    entry.Value.DataBindings.Clear();
                }
                DatabaseController.BindCustomerData(App.getCustomerValueLabels(), bindingNavigator_Customers);
                ViewMessages.customerAdded();
                newCustomerForm.Close();
            }
            catch (SqlException e) {
                ViewMessages.exceptionOccured(e);
            }
        }

        public static void showPhotoDialogChooser(OpenFileDialog dialog, TextBox photo_textbox)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                dialog.InitialDirectory = @"C:\";
                dialog.Title = "Select New Customer's photo";
                photo_textbox.Text = dialog.FileName;
            }
        }

        public static void openUpdateCustomerForm(Dictionary<String, Label> customerValueLabels, BindingNavigator bindingNavigator_Customers)
        {
            UpdateCustomer form = new UpdateCustomer(customerValueLabels, bindingNavigator_Customers);
            form.Show();
        }


        public static void updateCustomer(Dictionary<String, TextBox> updateCustomerTextboxes, String customer_id, BindingNavigator bindingNavigator_Customers)
        {
            if (! validateFields(updateCustomerTextboxes)){
                return;
            }

            // Refresh the Binding Navigator if customer was added succesfully
            try
            {
                DatabaseController.updateCustomer(updateCustomerTextboxes, customer_id);

                foreach (KeyValuePair<String, Label> entry in App.getCustomerValueLabels()) {
                    entry.Value.DataBindings.Clear();
                }

                DatabaseController.BindCustomerData(App.getCustomerValueLabels(), bindingNavigator_Customers);
                //DatabaseController.loadCustomerPhoto()
                ViewMessages.customerAdded();
                newCustomerForm.Close();
            }
            catch (SqlException e) {
                ViewMessages.exceptionOccured(e);
            }
        }
        
    }
}
