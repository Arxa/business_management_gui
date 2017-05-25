using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Digital_Storehouse.Models;

namespace Digital_Storehouse.Daos
{
    public class DatabaseConnection
    {
        public static SqlDataAdapter AdapterCustomer, AdapterProduct, AdapterOrder, AdapterOrdersProducts;
        public static DataSet DatasetCustomer, DatasetProducts, DatasetOrder, DatasetOrdersProducts;
        public static BindingSource BindsourceCustomer, BindsourceProducts, BindsourceOrders, BindsourceOrdersProducts;
        public static SqlConnection Conn;


        public DatabaseConnection(Dictionary<string, Label> customerValueLabels, BindingNavigator bindingNavigator, 
            Dictionary<string, Label> ProductValueLabels, BindingNavigator bindingNavigator_Products, 
            Dictionary<string, Label> OrderValueLabels, BindingNavigator bindingNavigator_Orders, 
            Dictionary<string, Label> OrderProductsValueLabels, BindingNavigator bindingNavigator_OrdersProducts)
        {
            Connect();
            BindCustomerData(customerValueLabels, bindingNavigator);
            BindProductsData(ProductValueLabels, bindingNavigator_Products);
            BindOrderData(OrderValueLabels, bindingNavigator_Orders);
            BindOrdersProductsData(OrderProductsValueLabels, bindingNavigator_OrdersProducts);
        }


        public static void Connect()
        {
            Conn = new SqlConnection
            {
                ConnectionString = Container.CONNECTION_STRING
            };
        }

        public static void BindCustomerData(Dictionary<string, Label> customerValueLabels, BindingNavigator bindingNavigator)
        {
            Conn.Open(); // Open Connection
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
            customerValueLabels["COMMENTS"].DataBindings.Add(new Binding("Text", BindsourceCustomer, "COMMENTS", true));
            customerValueLabels["HAS_PHOTO"].DataBindings.Add(new Binding("Text", BindsourceCustomer, "HAS_PHOTO", true));

            bindingNavigator.BindingSource = BindsourceCustomer;
            Conn.Close(); // Close Connection
        }

        public static void BindOrderData(Dictionary<String, Label> orderValueLabels, BindingNavigator bindingNavigator)
        {
            Conn.Open(); // Open Connection
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

        public static void BindProductsData(Dictionary<String, Label> productsValueLabels, BindingNavigator bindingNavigator)
        {
            Conn.Open(); // Open Connection
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

        public static void BindOrdersProductsData(Dictionary<String, Label> ordersProductsValueLabels, BindingNavigator bindingNavigator)
        {
            Conn.Open(); // Open Connection
            string query = "SELECT * FROM ORDERS_PRODUCTS";
            AdapterOrdersProducts = new SqlDataAdapter(query, Conn);
            DatasetOrdersProducts = new DataSet();
            AdapterOrdersProducts.Fill(DatasetOrdersProducts, "OrdersProducts_Table");

            BindsourceOrdersProducts = new BindingSource
            {
                DataSource = DatasetOrdersProducts.Tables[0].DefaultView
            };

            ordersProductsValueLabels["ID_ORDER"].DataBindings.Add(new Binding("Text", BindsourceOrdersProducts, "ID_ORDER", true));
            ordersProductsValueLabels["ID_PRODUCT"].DataBindings.Add(new Binding("Text", BindsourceOrdersProducts, "ID_PRODUCT", true));
            ordersProductsValueLabels["AMOUNT"].DataBindings.Add(new Binding("Text", BindsourceOrdersProducts, "AMOUNT", true));

            bindingNavigator.BindingSource = BindsourceOrdersProducts;
            Conn.Close(); // Close Connection
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
