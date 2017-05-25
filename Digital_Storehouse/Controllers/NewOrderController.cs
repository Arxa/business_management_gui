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
        public static void fillCustomerIdCombobox(ComboBox customerIdComboBox)
        {
            foreach (var customerId in NewOrderDAO.getAllCustomerIds())
            {
                customerIdComboBox.Items.Add(customerId);
            }
        }

        public static bool validateFields(Dictionary<String, MyTextBox> newOrderTextboxes)
        {
            // TODO change to combobox
            //if (newOrderTextboxes["PAYMENT METHOD"])

            return true;
        }



        public static void addNewOrder(Dictionary<String, MyTextBox> newOrderTextboxes, DateTimePicker orderDatePicker, 
            ComboBox customerIdsComboBox, BindingNavigator bindingNavigatorOrders, NewOrder newOrderForm)
        {
            if (! validateFields(newOrderTextboxes)){
                return;
            }

            try
            {
                int last_page = bindingNavigatorOrders.BindingSource.Count;

                NewOrderDAO.addNewOrder(newOrderTextboxes, orderDatePicker.Value.Date, customerIdsComboBox.GetItemText(customerIdsComboBox.SelectedItem));

                foreach (KeyValuePair<string, Label> entry in App.GetOrderLabels())
                {
                    entry.Value.DataBindings.Clear();
                }

                AppDAO.BindOrderData(App.GetOrderLabels(), bindingNavigatorOrders);

                bindingNavigatorOrders.BindingSource.Position = last_page;

                ViewMessages.OrderAdded();
                newOrderForm.Close();
            }
            catch (SqlException e)
            {
                ViewMessages.ExceptionOccured(e);
            }
        }



    }
}
