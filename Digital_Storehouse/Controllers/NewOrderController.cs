using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Digital_Storehouse.Daos;
using Digital_Storehouse.Models;
using System.Data.SqlClient;
using Digital_Storehouse.Views;

namespace Digital_Storehouse.Controllers
{
    public class NewOrderController
    {
        private static DatabaseConnection db = new DatabaseConnection();

        public static void fillCustomerIdCombobox(ComboBox customerIdComboBox)
        {
            foreach (var customerId in NewOrderDAO.getCustomerIds())
            {
                customerIdComboBox.Items.Add(customerId);
            }
        }

        public static bool validateFields(MyTextBox locationTextbox, ComboBox paymentMethod, ComboBox customerIdsComboBox)
        {
            if (locationTextbox.Text.Equals("") || paymentMethod.GetItemText(paymentMethod.SelectedItem).Equals("") ||
                customerIdsComboBox.GetItemText(customerIdsComboBox.SelectedItem).Equals(""))
            {
                ViewMessages.FillRequiredFields();
                return false;
            }

            return true;
        }



        public static void addNewOrder(MyTextBox locationTextbox, ComboBox paymentMethod, DateTimePicker orderDatePicker, 
            ComboBox customerIdsComboBox, BindingNavigator bindingNavigatorOrders, NewOrder newOrderForm)
        {
            if (! validateFields(locationTextbox, paymentMethod, customerIdsComboBox)){  
                return;
            }

            try
            {
                int last_page = bindingNavigatorOrders.BindingSource.Count;

                NewOrderDAO.addNewOrder(locationTextbox.Text, paymentMethod.GetItemText(paymentMethod.SelectedItem), 
                    orderDatePicker.Value.Date, customerIdsComboBox.GetItemText(customerIdsComboBox.SelectedItem));


                foreach (KeyValuePair<string, Label> entry in App.GetOrderLabels())
                {
                    entry.Value.DataBindings.Clear();
                }

                db.BindOrderData(App.GetOrderLabels(), bindingNavigatorOrders);

                bindingNavigatorOrders.BindingSource.Position = last_page;

                // Added!
                newOrderForm.Close();
            }
            catch (SqlException e)
            {
                ViewMessages.ExceptionOccured(e);
            }
        }



    }
}
