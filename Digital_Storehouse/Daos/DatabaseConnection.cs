using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Digital_Storehouse.Controllers;
using Digital_Storehouse.Models;

namespace Digital_Storehouse.Daos
{
    public class DatabaseConnection
    {
        public static SqlDataAdapter AdapterCustomer, AdapterProduct, AdapterOrder, AdapterOrdersProducts;
        public static DataSet DatasetCustomer, DatasetProducts, DatasetOrder, DatasetOrdersProducts;
        public static BindingSource BindsourceCustomer, BindsourceProducts, BindsourceOrders, BindsourceOrdersProducts;
        public static SqlConnection Conn;


        public DatabaseConnection()
        {
            Connect();   
        }


        public void Connect()
        {
            Conn = new SqlConnection
            {
                ConnectionString = Container.CONNECTION_STRING
            };
        }

        public void BindCustomerData(Dictionary<string, Label> customerValueLabels, RichTextBox commentsRichTextbox, BindingNavigator bindingNavigator)
        {
            openConnectionIfClosed();

            string query = "SELECT * FROM CUSTOMERS";
            AdapterCustomer = new SqlDataAdapter(query, Conn);
            DatasetCustomer = new DataSet();
            AdapterCustomer.Fill(DatasetCustomer, "Customers_Table");

            BindsourceCustomer = new BindingSource
            {
                DataSource = DatasetCustomer.Tables[0].DefaultView
            };

            customerValueLabels["CUSTOMER_ID"].DataBindings.Add(new Binding("Text", BindsourceCustomer, "CUSTOMER_ID", true));
            customerValueLabels["LAST_NAME"].DataBindings.Add(new Binding("Text", BindsourceCustomer, "LAST_NAME", true));
            customerValueLabels["FIRST_NAME"].DataBindings.Add(new Binding("Text", BindsourceCustomer, "FIRST_NAME", true));
            customerValueLabels["BIRTH_DATE"].DataBindings.Add(new Binding("Text", BindsourceCustomer, "BIRTH_DATE", true));
            customerValueLabels["AGE"].DataBindings.Add(new Binding("Text", BindsourceCustomer, "AGE", true));
            customerValueLabels["AFM"].DataBindings.Add(new Binding("Text", BindsourceCustomer, "AFM", true));
            customerValueLabels["DOY"].DataBindings.Add(new Binding("Text", BindsourceCustomer, "DOY", true));
            customerValueLabels["ADDRESS"].DataBindings.Add(new Binding("Text", BindsourceCustomer, "ADDRESS", true));
            customerValueLabels["CITY"].DataBindings.Add(new Binding("Text", BindsourceCustomer, "CITY", true));
            customerValueLabels["PHONE_NUMBER"].DataBindings.Add(new Binding("Text", BindsourceCustomer, "PHONE_NUMBER", true));
            commentsRichTextbox.DataBindings.Clear(); //TODO temporary bug fix
            commentsRichTextbox.DataBindings.Add(new Binding("Text", BindsourceCustomer, "COMMENTS", true));

            bindingNavigator.BindingSource = BindsourceCustomer;
            Conn.Close(); // Close Connection
        }

        public void BindOrderData(Dictionary<String, Label> orderValueLabels, BindingNavigator bindingNavigator)
        {
            openConnectionIfClosed();

            string query = "SELECT * FROM ORDERS";
            AdapterOrder = new SqlDataAdapter(query, Conn);
            DatasetOrder = new DataSet();
            AdapterOrder.Fill(DatasetOrder, "Orders_Table");

            BindsourceOrders = new BindingSource
            {
                DataSource = DatasetOrder.Tables[0].DefaultView
            };

            orderValueLabels["ORDER_ID"].DataBindings.Add(new Binding("Text", BindsourceOrders, "ORDER_ID", true));
            orderValueLabels["ORDER_DATE"].DataBindings.Add(new Binding("Text", BindsourceOrders, "ORDER_DATE", true));
            orderValueLabels["CUSTOMER_ID_F"].DataBindings.Add(new Binding("Text", BindsourceOrders, "CUSTOMER_ID", true));
            orderValueLabels["PAYMENT_METHOD"].DataBindings.Add(new Binding("Text", BindsourceOrders, "PAYMENT_METHOD", true));
            orderValueLabels["DELIVERY_LOCATION"].DataBindings.Add(new Binding("Text", BindsourceOrders, "DELIVERY_LOCATION", true));

            bindingNavigator.BindingSource = BindsourceOrders;
            Conn.Close(); // Close Connection
        }

        public void BindProductsData(Dictionary<String, Label> productsValueLabels, BindingNavigator bindingNavigator)
        {
            openConnectionIfClosed();

            string query = "SELECT * FROM PRODUCTS";
            AdapterProduct = new SqlDataAdapter(query, Conn);
            DatasetProducts = new DataSet();
            AdapterProduct.Fill(DatasetProducts, "Products_Table");

            BindsourceProducts = new BindingSource
            {
                DataSource = DatasetProducts.Tables[0].DefaultView
            };

            productsValueLabels["PRODUCT_ID"].DataBindings.Add(new Binding("Text", BindsourceProducts, "PRODUCT_ID", true));
            productsValueLabels["LABEL"].DataBindings.Add(new Binding("Text", BindsourceProducts, "LABEL", true));
            productsValueLabels["CATEGORY"].DataBindings.Add(new Binding("Text", BindsourceProducts, "CATEGORY", true));
            productsValueLabels["RESERVE"].DataBindings.Add(new Binding("Text", BindsourceProducts, "RESERVE", true));
            productsValueLabels["SELLING_PRICE"].DataBindings.Add(new Binding("Text", BindsourceProducts, "SELLING_PRICE", true));
            productsValueLabels["MANUFACTURER"].DataBindings.Add(new Binding("Text", BindsourceProducts, "MANUFACTURER", true));

            bindingNavigator.BindingSource = BindsourceProducts;
            Conn.Close(); // Close Connection
        }

        public void BindOrdersProductsData(Dictionary<String, Label> ordersProductsValueLabels, BindingNavigator bindingNavigator)
        {
            openConnectionIfClosed();

            string query = "SELECT * FROM ORDERS_PRODUCTS";
            AdapterOrdersProducts = new SqlDataAdapter(query, Conn);
            DatasetOrdersProducts = new DataSet();
            AdapterOrdersProducts.Fill(DatasetOrdersProducts, "OrdersProducts_Table");

            BindsourceOrdersProducts = new BindingSource
            {
                DataSource = DatasetOrdersProducts.Tables[0].DefaultView
            };

            ordersProductsValueLabels["ORDER_ID_F"].DataBindings.Add(new Binding("Text", BindsourceOrdersProducts, "ID_ORDER", true));
            ordersProductsValueLabels["PRODUCT_ID_F"].DataBindings.Add(new Binding("Text", BindsourceOrdersProducts, "ID_PRODUCT", true));
            ordersProductsValueLabels["AMOUNT"].DataBindings.Add(new Binding("Text", BindsourceOrdersProducts, "AMOUNT", true));

            bindingNavigator.BindingSource = BindsourceOrdersProducts;
            Conn.Close(); // Close Connection
        }




        public void BindOrdersHistoryDataGrid(DataGridView ordersHistory_dataGridView, string customerId)
        {
            int customerID;
            if (! int.TryParse(customerId, out customerID)){
                return;
            }

            openConnectionIfClosed();
            
            string query = 
            "SELECT LAST_NAME, PAYMENT_METHOD, LABEL AS PRODUCT, SELLING_PRICE AS UNIT_PRICE, AMOUNT FROM CUSTOMERS "+ 
            "INNER JOIN ORDERS "+
                "ON CUSTOMERS.CUSTOMER_ID = ORDERS.CUSTOMER_ID " +
            "INNER JOIN ORDERS_PRODUCTS "+
                "ON ORDERS_PRODUCTS.ID_ORDER = ORDERS.ORDER_ID "+
            "INNER JOIN PRODUCTS "+
                "ON PRODUCTS.PRODUCT_ID = ORDERS_PRODUCTS.ID_PRODUCT "+
            "WHERE CUSTOMERS.CUSTOMER_ID = "+customerId;
            
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, Conn);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataset.Tables[0].DefaultView;
                ordersHistory_dataGridView.DataSource = bindingSource;
            }
            catch (SqlException e)
            {
                ViewMessages.ExceptionOccured(e);
            }
            Conn.Close(); // Close Connection
        }

        public void BindProductsHistoryDataGrid(DataGridView productsHistoryDataGridView, string productId)
        {
            int productID;
            if (!int.TryParse(productId, out productID)){
                return;
            }

            openConnectionIfClosed();

            string query =
                "SELECT LABEL AS PRODUCT, LAST_NAME AS ORDERED_BY, PAYMENT_METHOD, SELLING_PRICE AS UNIT_PRICE, AMOUNT FROM ORDERS " +
                "INNER JOIN ORDERS_PRODUCTS " +
                    "ON ORDERS_PRODUCTS.ID_ORDER = ORDERS.ORDER_ID " +
                "INNER JOIN PRODUCTS " +
                    "ON PRODUCTS.PRODUCT_ID = ORDERS_PRODUCTS.ID_PRODUCT " +
                "INNER JOIN CUSTOMERS " +
                    "ON CUSTOMERS.CUSTOMER_ID = ORDERS.CUSTOMER_ID " +
                "WHERE ORDERS.ORDER_ID = " + productId;

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, Conn);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataset.Tables[0].DefaultView;
                productsHistoryDataGridView.DataSource = bindingSource;
            }
            catch (SqlException e)
            {
                ViewMessages.ExceptionOccured(e);
            }
            Conn.Close(); // Close Connection
        }

        public static DataSet GetDataSet()
        {
            openConnectionIfClosed();

            string query = "SELECT * FROM CUSTOMERS";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Conn);
            DataSet dataset = new DataSet();
            
            adapter.Fill(dataset, "Test_Table");

            return dataset;
        }


        public static BindingSource getBindSourceCustomer()
        {
            return BindsourceCustomer;
        }

        public static BindingSource getBindSourceProducts()
        {
            return BindsourceProducts;
        }

        public static BindingSource getBindSourceOrders()
        {
            return BindsourceOrders;
        }

        public static BindingSource getBindSourceOrdersProducts()
        {
            return BindsourceOrdersProducts;
        }


        public static byte[] GetImageBytesFromPath(string path)
        {
            Image img = Image.FromFile(path);
            MemoryStream tmpStream = new MemoryStream();
            img.Save(tmpStream, ImageFormat.Png); // change to other format
            tmpStream.Seek(0, SeekOrigin.Begin);
            byte[] imgBytes = new byte[256000];
            tmpStream.Read(imgBytes, 0, 256000);
            return imgBytes;
        }

        public static byte[] GetImageBytesFromImage(Image image)
        {
            MemoryStream tmpStream = new MemoryStream();
            image.Save(tmpStream, ImageFormat.Png); // change to other format
            tmpStream.Seek(0, SeekOrigin.Begin);
            byte[] imgBytes = new byte[256000];
            tmpStream.Read(imgBytes, 0, 256000);
            return imgBytes;
        }

        public static void openConnectionIfClosed()
        {
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
        }
    }
}
