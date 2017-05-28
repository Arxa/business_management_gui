using Digital_Storehouse.Daos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Digital_Storehouse.Views;

namespace Digital_Storehouse.Controllers
{
    class UpdateOrderController
    {
        private static DatabaseConnection db = new DatabaseConnection();

        public static void fillCustomerIdCombobox(ComboBox customerIdComboBox)
        {
            foreach (var customerId in NewOrderDAO.getCustomerIds())
            {
                customerIdComboBox.Items.Add(customerId);
            }
        }

        public static bool validateFields(ComboBox customerId_combobox, ComboBox paymentMethod_combobox, TextBox deliveryLocation)
        {
            if (deliveryLocation.Text.Equals("") || paymentMethod_combobox.GetItemText(paymentMethod_combobox.SelectedItem).Equals("") ||
                customerId_combobox.GetItemText(customerId_combobox.SelectedItem).Equals(""))
            {
                ViewMessages.FillRequiredFields();
                return false;
            }

            return true;
        }



        public static void updateOrder(ComboBox customerId_combobox, ComboBox paymentMethod_combobox, TextBox location_Textbox, DateTimePicker orderDatePicker,
                                    BindingNavigator bindingNavigatorOrders, UpdateOrder updateOrderForm, int orderId)
        {
            if (!validateFields(customerId_combobox, paymentMethod_combobox, location_Textbox))           {                
                return;
            }

            try
            {
                int currentPage = bindingNavigatorOrders.BindingSource.Position;

                UpdateOrderDAO.updateOrder(orderDatePicker.Value.Date, Int32.Parse(customerId_combobox.GetItemText(customerId_combobox.SelectedItem)),
                    paymentMethod_combobox.GetItemText(paymentMethod_combobox.SelectedItem), location_Textbox.Text, orderId);


                foreach (KeyValuePair<string, Label> entry in App.GetOrderLabels())
                {
                    entry.Value.DataBindings.Clear();
                }

                db.BindOrderData(App.GetOrderLabels(), bindingNavigatorOrders);

                bindingNavigatorOrders.BindingSource.Position = currentPage;

                // Updated!
                updateOrderForm.Close();
            }
            catch (SqlException e)
            {
                ViewMessages.ExceptionOccured(e);
            }
        }


    }
}
