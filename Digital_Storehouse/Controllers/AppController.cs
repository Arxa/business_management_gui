using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
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
        private static DatabaseConnection db = new DatabaseConnection();

        public static void DeleteCustomer(Dictionary<string, Label> customerValueLabels, RichTextBox commentsRichTextBox, BindingNavigator bindingNavigatorCustomer)
        {
            if (!customerCanBeDeleted(customerValueLabels["CUSTOMER_ID"].Text))
            {
                ViewMessages.CannotDeleteCustomer();
                return;
            }

            if (ViewMessages.DeleteCustomerDialog() == DialogResult.No)
            {
                return;
            }
            AppDAO.DeleteCustomer(Int32.Parse(customerValueLabels["CUSTOMER_ID"].Text));
            foreach (KeyValuePair<string, Label> entry in customerValueLabels)
            {
                entry.Value.DataBindings.Clear();
            }
            db.BindCustomerData(customerValueLabels, commentsRichTextBox, bindingNavigatorCustomer);
        }

        public static void DeleteOrder(Dictionary<string, Label> orderValueLabels, BindingNavigator bindingNavigatorOrder)
        {
            if (! orderCanBeDeleted(orderValueLabels["ORDER_ID"].Text))
            {
                ViewMessages.CannotDeleteOrder();
                return;
            }

            if (ViewMessages.DeleteOrderDialog() == DialogResult.No)
            {
                return;
            }
            AppDAO.DeleteOrder(Int32.Parse(orderValueLabels["ORDER_ID"].Text));
            foreach (KeyValuePair<string, Label> entry in orderValueLabels)
            {
                entry.Value.DataBindings.Clear();
            }
            db.BindOrderData(orderValueLabels, bindingNavigatorOrder);
        }

        public static void DeleteProduct(Dictionary<string, Label> productValueLabels, BindingNavigator bindingNavigatorProduct)
        {
            if (!productCanBeDeleted(productValueLabels["PRODUCT_ID"].Text))
            {
                ViewMessages.CannotDeleteProduct();
                return;
            }

            if (ViewMessages.DeleteProductDialog() == DialogResult.No)
            {
                return;
            }
            AppDAO.DeleteProduct(Int32.Parse(productValueLabels["PRODUCT_ID"].Text));
            foreach (KeyValuePair<string, Label> entry in productValueLabels)
            {
                entry.Value.DataBindings.Clear();
            }
            db.BindProductsData(productValueLabels, bindingNavigatorProduct);
        }

        public static void DeleteRelationship(Dictionary<string, Label> ordersProductsValueLabels, BindingNavigator bindingNavigatorOrdersProducts)
        {
            if (ViewMessages.DeleteRelationshipDialog() == DialogResult.No)
            {
                return;
            }
            AppDAO.DeleteRelationship(Int32.Parse(ordersProductsValueLabels["ORDER_ID_F"].Text));
            foreach (KeyValuePair<string, Label> entry in ordersProductsValueLabels)
            {
                entry.Value.DataBindings.Clear();
            }
            db.BindOrdersProductsData(ordersProductsValueLabels, bindingNavigatorOrdersProducts);
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


        public static void syncOrdersTab(BindingSource ordersBindSource,Dictionary<String, Label> ordersValueLabels,
                                    Button deleteOrderButton, Button updateOrderButton)
        {
            if (ordersBindSource == null)
            {
                // Binding Source has not yet loaded - cancel
                return;
            }

            if (ordersBindSource.Count == 0)
            {
                foreach (KeyValuePair<String, Label> entry in ordersValueLabels)
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
                foreach (KeyValuePair<String, Label> entry in ordersProductsValueLabels)
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

        public static void OpenUpdateCustomerForm(Dictionary<string, Label> customerValueLabels, PictureBox pictureBox, 
                                        RichTextBox commentsRichTextBox, BindingNavigator bindingNavigatorCustomers)
        {
            UpdateCustomer form = new UpdateCustomer(customerValueLabels, pictureBox, commentsRichTextBox, bindingNavigatorCustomers);
            form.Show();
        }

        public static void OpenUpdateOrderForm(Dictionary<string, Label> orderValueLabels, BindingNavigator bindingNavigatorCustomers)
        {
            UpdateOrder form = new UpdateOrder(orderValueLabels, bindingNavigatorCustomers);
            form.Show();
        }


        
        public static bool orderCanBeDeleted(string orderId)
        {
            foreach (var id in NewOrdersProductsDAO.getOrderIdsInOrdersProductsTable())
            {
                if (id.Equals(orderId))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool productCanBeDeleted(string productId)
        {
            foreach (var id in NewOrdersProductsDAO.getProductIdsInOrdersProductsTable())
            {
                if (id.Equals(productId))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool customerCanBeDeleted(string customerId)
        {
            foreach (var id in NewOrderDAO.getCustomerIdsInOrdersProductsTable())
            {
                if (id.Equals(customerId))
                {
                    return false;
                }
            }
            return true;
        }

        public static void createCustomersHistoryDataGrid(DataGridView ordersHistory_dataGridView, ComboBox customerIds_combobox, DataGridViewTextBoxColumn totalColumn, Label ordersHistoryTotal_label)
        {
            db.BindOrdersHistoryDataGrid(ordersHistory_dataGridView, customerIds_combobox.GetItemText(customerIds_combobox.SelectedItem));

            if (!ordersHistory_dataGridView.Columns.Contains(totalColumn))
            {
                ordersHistory_dataGridView.Columns.Add(totalColumn);
            }

            int index = ordersHistory_dataGridView.Columns.IndexOf(totalColumn);

            float grandTotal = 0;

            for (int i = 0; i < ordersHistory_dataGridView.RowCount; i++)
            {
                float total = float.Parse(ordersHistory_dataGridView.Rows[i].Cells["UNIT_PRICE"].Value.ToString()) *
                              float.Parse(ordersHistory_dataGridView.Rows[i].Cells["AMOUNT"].Value.ToString());

                ordersHistory_dataGridView.Rows[i].Cells[index].Value = total;
                grandTotal += total;
            }
            ordersHistoryTotal_label.Text = Convert.ToString(grandTotal, CultureInfo.InvariantCulture);

            foreach (DataGridViewColumn column in ordersHistory_dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public static void exportDataForPrinter(DataGridView ordersHistory_dataGridView, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(ordersHistory_dataGridView.Width, ordersHistory_dataGridView.Height);
            ordersHistory_dataGridView.DrawToBitmap(bm, new Rectangle(0, 0, ordersHistory_dataGridView.Width, ordersHistory_dataGridView.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
