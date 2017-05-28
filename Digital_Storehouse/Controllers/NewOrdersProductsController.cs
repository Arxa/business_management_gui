using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digital_Storehouse.Daos;
using System.Windows.Forms;
using Digital_Storehouse.Views;

namespace Digital_Storehouse.Controllers
{
    class NewOrdersProductsController
    {
        private static DatabaseConnection db = new DatabaseConnection();

        public static void fillcomboboxes(ComboBox orderIdComboBox, ComboBox productIdComboBox)
        {
            foreach (var orderId in NewOrdersProductsDAO.getOrdersIds())
            {
                orderIdComboBox.Items.Add(orderId);
            }

            foreach (var productId in NewOrdersProductsDAO.getProductsIds())
            {
                productIdComboBox.Items.Add(productId);
            }
        }

        public static void fillcombobox(ComboBox productIdComboBox)
        {
            foreach (var orderId in NewOrdersProductsDAO.getOrdersIds())
            {
                productIdComboBox.Items.Add(orderId);
            }
        }

        public static bool validateFields(TextBox amount, ComboBox orderIdComboBox, ComboBox productIdComboBox)
        {
            if (amount.Text.Equals("") || orderIdComboBox.GetItemText(orderIdComboBox.SelectedItem).Equals("") ||
                productIdComboBox.GetItemText(productIdComboBox.SelectedItem).Equals(""))
            {
                ViewMessages.FillRequiredFields();
                return false;
            }

            float n;
            if (! float.TryParse(amount.Text, out n))
            {
                ViewMessages.AmountNotValid();
                return false;
            }


            return true;
        }

        public static void addNewOrdersProducts(TextBox amountTextBox, ComboBox orderIdComboBox, ComboBox productIdComboBox, 
                                BindingNavigator bindingNavigatorOrdersProducts, NewOrdersProducts newOrderProductsForm)
        {
            if (!validateFields(amountTextBox, orderIdComboBox, productIdComboBox)){   
                return;
            }

            try
            {
                int last_page = bindingNavigatorOrdersProducts.BindingSource.Count;
                int orderId = Int32.Parse(orderIdComboBox.GetItemText(orderIdComboBox.SelectedItem));
                int productId = Int32.Parse(productIdComboBox.GetItemText(productIdComboBox.SelectedItem));
                float amount = float.Parse(amountTextBox.Text);

                // Check for DUPLICATE KEY
                if (NewOrdersProductsDAO.checkIfKeyAlreadyExists(orderId, productId))
                {
                    ViewMessages.DuplicateKeyError();
                    return;
                }

                NewOrdersProductsDAO.addNewOrdersProducts(orderId, productId, amount);

                foreach (KeyValuePair<string, Label> entry in App.GetOrdersProductsLabels())
                {
                    entry.Value.DataBindings.Clear();
                }

                db.BindOrdersProductsData(App.GetOrdersProductsLabels(), bindingNavigatorOrdersProducts);

                bindingNavigatorOrdersProducts.BindingSource.Position = last_page;

                // Added!
                newOrderProductsForm.Close();
            }
            catch (SqlException e)
            {
                ViewMessages.ExceptionOccured(e);
            }
        }

        
    }
}
