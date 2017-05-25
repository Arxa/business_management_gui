using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Digital_Storehouse.Daos;
using Digital_Storehouse.Views;

namespace Digital_Storehouse.Controllers
{
    public class AppController
    {
        public static void DeleteCustomer(Dictionary<string, Label> customerValueLabels, BindingNavigator bindingNavigatorCustomer)
        {
            if (ViewMessages.DeleteCustomerDialog() == DialogResult.No)
            {
                return;
            }
            AppDAO.DeleteCustomer(Int32.Parse(customerValueLabels["CUSTOMER_ID"].Text));
            foreach (KeyValuePair<string, Label> entry in customerValueLabels)
            {
                entry.Value.DataBindings.Clear();
            }
            AppDAO.BindCustomerData(customerValueLabels, bindingNavigatorCustomer);
        }

        public static void DeleteOrder(Dictionary<string, Label> orderValueLabels, BindingNavigator bindingNavigatorOrder)
        {
            if (ViewMessages.DeleteOrderDialog() == DialogResult.No)
            {
                return;
            }
            AppDAO.DeleteOrder(Int32.Parse(orderValueLabels["ORDER_ID"].Text));
            foreach (KeyValuePair<string, Label> entry in orderValueLabels)
            {
                entry.Value.DataBindings.Clear();
            }
            AppDAO.BindOrderData(orderValueLabels, bindingNavigatorOrder);
        }

        public static void DeleteProduct(Dictionary<string, Label> productValueLabels, BindingNavigator bindingNavigatorProduct)
        {
            if (ViewMessages.DeleteProductDialog() == DialogResult.No)
            {
                return;
            }
            AppDAO.DeleteProduct(Int32.Parse(productValueLabels["PRODUCT_ID"].Text));
            foreach (KeyValuePair<string, Label> entry in productValueLabels)
            {
                entry.Value.DataBindings.Clear();
            }
            AppDAO.BindProductsData(productValueLabels, bindingNavigatorProduct);
        }

        public static void DeleteRelationship(Dictionary<string, Label> ordersProductsValueLabels, BindingNavigator bindingNavigatorOrdersProducts)
        {
            if (ViewMessages.DeleteRelationshipDialog() == DialogResult.No)
            {
                return;
            }
            AppDAO.DeleteRelationship(Int32.Parse(ordersProductsValueLabels["ID_ORDER"].Text));
            foreach (KeyValuePair<string, Label> entry in ordersProductsValueLabels)
            {
                entry.Value.DataBindings.Clear();
            }
            AppDAO.BindOrdersProductsData(ordersProductsValueLabels, bindingNavigatorOrdersProducts);
        }



        public static void syncCustomersTab(BindingSource customerBindSource, Dictionary<String, Label> customerValueLabels,
            PictureBox pictureBox, Button deleteCustomerButton, Button updateCustomButton)
        {
            if (customerBindSource == null)
            {
                // Binding Source has not yet loaded - cancel
                return;
            }

            if (customerBindSource.Count == 0)
            {
                foreach (KeyValuePair<String, Label> entry in customerValueLabels)
                {
                    entry.Value.Text = "XXX";
                }
                pictureBox.Image = null;
                deleteCustomerButton.Enabled = false;
                updateCustomButton.Enabled = false;
                return;
            }
            deleteCustomerButton.Enabled = true;
            updateCustomButton.Enabled = true;
            AppDAO.LoadCustomerPhoto(pictureBox, Int32.Parse(customerValueLabels["CUSTOMER_ID"].Text));
        }

        public static void syncProductsTab(BindingSource productsBindSource,
            Dictionary<String, Label> productsValueLabels,
            Button deleteProductButton, Button updateProductButton)
        {
            if (productsBindSource == null)
            {
                // Binding Source has not yet loaded - cancel
                return;
            }

            if (productsBindSource.Count == 0)
            {
                foreach (KeyValuePair<String, Label> entry in productsValueLabels)
                {
                    entry.Value.Text = "XXX";
                }
                deleteProductButton.Enabled = false;
                updateProductButton.Enabled = false;
                return;
            }
            deleteProductButton.Enabled = true;
            updateProductButton.Enabled = true;
        }


        public static void syncOrdersTab(BindingSource ordersBindSource,
            Dictionary<String, Label> ordersValueLabels,
            Button deleteOrderButton, Button updateOrderButton)
        {
            if (ordersBindSource == null)
            {
                // Binding Source has not yet loaded - cancel
                return;
            }

            if (ordersBindSource.Count == 0)
            {
                foreach (KeyValuePair<String, Label> entry in ordersBindSource)
                {
                    entry.Value.Text = "XXX";
                }
                deleteOrderButton.Enabled = false;
                updateOrderButton.Enabled = false;
                return;
            }
            deleteOrderButton.Enabled = true;
            updateOrderButton.Enabled = true;
        }

        public static void syncOrdersProductsTab(BindingSource ordersProductsBindSource,
            Dictionary<String, Label> ordersProductsValueLabels,
            Button deleteOrdersProductsButton, Button updateOrdersProductsButton)
        {
            if (ordersProductsBindSource == null)
            {
                // Binding Source has not yet loaded - cancel
                return;
            }

            if (ordersProductsBindSource.Count == 0)
            {
                foreach (KeyValuePair<String, Label> entry in ordersProductsBindSource)
                {
                    entry.Value.Text = "XXX";
                }
                deleteOrdersProductsButton.Enabled = false;
                updateOrdersProductsButton.Enabled = false;
                return;
            }
            deleteOrdersProductsButton.Enabled = true;
            updateOrdersProductsButton.Enabled = true;
        }

        

        public static void OpenNewCustomerForm(BindingNavigator bindingNavigatorCustomer)
        {
            NewCustomer form = new NewCustomer(bindingNavigatorCustomer);
            form.Show();
        }

        public static void OpenUpdateCustomerForm(Dictionary<string, Label> customerValueLabels, PictureBox pictureBox, BindingNavigator bindingNavigatorCustomers)
        {
            UpdateCustomer form = new UpdateCustomer(customerValueLabels, pictureBox, bindingNavigatorCustomers);
            form.Show();
        }
    }
}
