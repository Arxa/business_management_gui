using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Digital_Storehouse.Daos;
using Digital_Storehouse.Models;
using Digital_Storehouse.Views;

namespace Digital_Storehouse.Controllers
{
    public class UpdateCustomerController
    {
        public static void UpdateCustomer(Dictionary<String, MyTextBox> updateCustomerTextboxes, int customerId,
            PictureBox customerPictureBox, BindingNavigator bindingNavigatorCustomers, UpdateCustomer updateCustomerForm)
        {
            if (!NewCustomerController.ValidateFields(updateCustomerTextboxes))
            {
                return;
            }

            // Refresh the Binding Navigator if customer was updated succesfully
            try
            {
                UpdateCustomerDAO.UpdateCustomer(updateCustomerTextboxes, customerId);

                int currentPage = bindingNavigatorCustomers.BindingSource.Position;
                foreach (KeyValuePair<String, Label> entry in App.GetCustomerLabels())
                {
                    entry.Value.DataBindings.Clear();
                }

                AppDAO.BindCustomerData(App.GetCustomerLabels(), bindingNavigatorCustomers);
                bindingNavigatorCustomers.BindingSource.Position = currentPage;

                AppDAO.LoadCustomerPhoto(customerPictureBox, customerId);

                ViewMessages.CustomerUpdated();
                updateCustomerForm.Close();
            }
            catch (SqlException e)
            {
                ViewMessages.ExceptionOccured(e);
            }
        }

        public static void syncCustomerUpdatedForm(MyTextBox photo_textbox, Button removePhoto_button)
        {
            if (photo_textbox.Text.Equals(Container.EMPTY))
            {
                removePhoto_button.Enabled = false;
                return;
            }
            removePhoto_button.Enabled = true;
        }

        public static void removePhoto(PictureBox pictureBox1)
        {
            pictureBox1.Image = null;
        }
    }
}
