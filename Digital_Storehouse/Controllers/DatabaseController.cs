using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Digital_Storehouse.Controllers
{
    class DatabaseController
    {
        public static SqlDataAdapter adapterCustomer, adapterProduct, adapterOrder, adapterOrdersProducts;
        public static DataSet datasetCustomer, datasetProducts, datasetOrder, datasetOrdersProducts;
        public static BindingSource bindsourceCustomer, bindsourceProducts, bindsourceOrder, bindsourceOrdersProducts;
        public static SqlConnection conn;

        public static void Connect()
        {
            conn = new SqlConnection()
            {
                ConnectionString = "Data Source=ARXA-PC;Initial Catalog=Storehouse;Integrated Security=True"
            };
        }

        public static void BindCustomerData(Dictionary<String, Label> customerValueLabels, BindingNavigator bindingNavigator)
        {  
            conn.Open();
            string query = "SELECT * FROM CUSTOMERS";

            adapterCustomer = new SqlDataAdapter(query, conn);
            datasetCustomer = new DataSet();
            adapterCustomer.Fill(datasetCustomer, "Customers_Table");

            bindsourceCustomer = new BindingSource()
            {
                DataSource = datasetCustomer.Tables[0].DefaultView
            };
            customerValueLabels["CUSTOMER_ID"].DataBindings.Add(new Binding("Text", bindsourceCustomer, "CUSTOMER_ID", true));
            customerValueLabels["LAST_NAME"].DataBindings.Add(new Binding("Text", bindsourceCustomer, "LAST_NAME", true));
            customerValueLabels["FIRST_NAME"].DataBindings.Add(new Binding("Text", bindsourceCustomer, "FIRST_NAME", true));
            customerValueLabels["BIRTH_DATE"].DataBindings.Add(new Binding("Text", bindsourceCustomer, "BIRTH_DATE", true));
            customerValueLabels["AGE"].DataBindings.Add(new Binding("Text", bindsourceCustomer, "AGE", true));
            customerValueLabels["AFM"].DataBindings.Add(new Binding("Text", bindsourceCustomer, "AFM", true));
            customerValueLabels["DOY"].DataBindings.Add(new Binding("Text", bindsourceCustomer, "DOY", true));
            customerValueLabels["ADDRESS"].DataBindings.Add(new Binding("Text", bindsourceCustomer, "ADDRESS", true));
            customerValueLabels["CITY"].DataBindings.Add(new Binding("Text", bindsourceCustomer, "CITY", true));
            customerValueLabels["PHONE_NUMBER"].DataBindings.Add(new Binding("Text", bindsourceCustomer, "PHONE_NUMBER", true));
            customerValueLabels["PHOTO"].DataBindings.Add(new Binding("Text", bindsourceCustomer, "PHOTO", true));
            customerValueLabels["COMMENTS"].DataBindings.Add(new Binding("Text", bindsourceCustomer, "COMMENTS", true));

            bindingNavigator.BindingSource = bindsourceCustomer;
            conn.Close();
        }

        public static void BindOrderData(Dictionary<String, Label> orderValueLabels, BindingNavigator bindingNavigator)
        {
            conn.Open();
            string query = "SELECT * FROM ORDERS";

            adapterOrder = new SqlDataAdapter(query, conn);
            datasetOrder = new DataSet();
            try
            {
                adapterOrder.Fill(datasetOrder, "Orders_Table");
            }
            catch (SqlException e)
            {
                
                Console.WriteLine("IOException source: {0}",e.ToString());
            }

            bindsourceOrder = new BindingSource()
            {
                DataSource = datasetOrder.Tables[0].DefaultView
            };
            orderValueLabels["ORDER_ID"].DataBindings.Add(new Binding("Text", bindsourceOrder, "ORDER_ID", true));
            orderValueLabels["ORDER_DATE"].DataBindings.Add(new Binding("Text", bindsourceOrder, "ORDER_DATE", true));
            orderValueLabels["CUSTOMER_ID_F"].DataBindings.Add(new Binding("Text", bindsourceOrder, "CUSTOMER_ID", true));
            orderValueLabels["PAYMENT_METHOD"].DataBindings.Add(new Binding("Text", bindsourceOrder, "PAYMENT_METHOD", true));
            orderValueLabels["DELIVERY_LOCATION"].DataBindings.Add(new Binding("Text", bindsourceOrder, "DELIVERY_LOCATION", true));  

            bindingNavigator.BindingSource = bindsourceOrder;
            conn.Close();
        }

        public static void BindProductsData(Dictionary<String, Label> productsValueLabels, BindingNavigator bindingNavigator)
        {
            conn.Open();
            string query = "SELECT * FROM PRODUCTS";

            adapterProduct = new SqlDataAdapter(query, conn);
            datasetProducts = new DataSet();
            try
            {
                adapterProduct.Fill(datasetProducts, "Products_Table");
            }
            catch (SqlException e)
            {

                Console.WriteLine("IOException source: {0}", e.ToString());
            }

            bindsourceProducts = new BindingSource()
            {
                DataSource = datasetProducts.Tables[0].DefaultView
            };
            productsValueLabels["PRODUCT_ID"].DataBindings.Add(new Binding("Text", bindsourceProducts, "PRODUCT_ID", true));
            productsValueLabels["LABEL"].DataBindings.Add(new Binding("Text", bindsourceProducts, "LABEL", true));
            productsValueLabels["CATEGORY"].DataBindings.Add(new Binding("Text", bindsourceProducts, "CATEGORY", true));
            productsValueLabels["RESERVE"].DataBindings.Add(new Binding("Text", bindsourceProducts, "RESERVE", true));
            productsValueLabels["SELLING_PRICE"].DataBindings.Add(new Binding("Text", bindsourceProducts, "SELLING_PRICE", true));
            productsValueLabels["MANUFACTURER"].DataBindings.Add(new Binding("Text", bindsourceProducts, "MANUFACTURER", true));

            bindingNavigator.BindingSource = bindsourceProducts;
            conn.Close();
        }

        public static void BindOrdersProductsData(Dictionary<String, Label> ordersProductsValueLabels, BindingNavigator bindingNavigator)
        {
            conn.Open();
            string query = "SELECT * FROM ORDERS_PRODUCTS";

            adapterOrdersProducts = new SqlDataAdapter(query, conn);
            datasetOrdersProducts = new DataSet();
            try
            {
                adapterOrdersProducts.Fill(datasetOrdersProducts, "OrdersProducts_Table");
            }
            catch (SqlException e)
            {

                Console.WriteLine("IOException source: {0}", e.ToString());
            }

            bindsourceOrdersProducts = new BindingSource()
            {
                DataSource = datasetOrdersProducts.Tables[0].DefaultView
            };
            ordersProductsValueLabels["ID_ORDER"].DataBindings.Add(new Binding("Text", bindsourceOrdersProducts, "ID_ORDER", true));
            ordersProductsValueLabels["ID_PRODUCT"].DataBindings.Add(new Binding("Text", bindsourceOrdersProducts, "ID_PRODUCT", true));
            ordersProductsValueLabels["AMOUNT"].DataBindings.Add(new Binding("Text", bindsourceOrdersProducts, "AMOUNT", true));

            bindingNavigator.BindingSource = bindsourceOrdersProducts;
            conn.Close();
        }

        public static SqlConnection GetConnection()
        {
            if (conn != null)
            {
                return conn;
            }
            else
            {
                Console.WriteLine("CONNECTION IS NOT OPENED YET");
                return null;
            }
        }

        public static void CloseConnection()
        {
           conn.Close();
        }
    }
}
