using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;


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
            conn.Open(); // Open Connection
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
            customerValueLabels["COMMENTS"].DataBindings.Add(new Binding("Text", bindsourceCustomer, "COMMENTS", true));
            //customerValueLabels["PHOTO"].DataBindings.Add(new Binding("Text", bindsourceCustomer, "PHOTO", true));

            bindingNavigator.BindingSource = bindsourceCustomer;
            conn.Close(); // Close Connection
        }

        public static void BindOrderData(Dictionary<String, Label> orderValueLabels, BindingNavigator bindingNavigator)
        {
            conn.Open(); // Open Connection
            string query = "SELECT * FROM ORDERS";
            adapterOrder = new SqlDataAdapter(query, conn);
            datasetOrder = new DataSet();
            adapterOrder.Fill(datasetOrder, "Orders_Table");         

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
            conn.Close(); // Close Connection
        }

        public static void BindProductsData(Dictionary<String, Label> productsValueLabels, BindingNavigator bindingNavigator)
        {
            conn.Open(); // Open Connection
            string query = "SELECT * FROM PRODUCTS";
            adapterProduct = new SqlDataAdapter(query, conn);
            datasetProducts = new DataSet();
            adapterProduct.Fill(datasetProducts, "Products_Table");

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
            conn.Close(); // Close Connection
        }

        public static void BindOrdersProductsData(Dictionary<String, Label> ordersProductsValueLabels, BindingNavigator bindingNavigator)
        {
            conn.Open(); // Open Connection
            string query = "SELECT * FROM ORDERS_PRODUCTS";
            adapterOrdersProducts = new SqlDataAdapter(query, conn);
            datasetOrdersProducts = new DataSet();
            adapterOrdersProducts.Fill(datasetOrdersProducts, "OrdersProducts_Table");

            bindsourceOrdersProducts = new BindingSource()
            {
                DataSource = datasetOrdersProducts.Tables[0].DefaultView
            };

            ordersProductsValueLabels["ID_ORDER"].DataBindings.Add(new Binding("Text", bindsourceOrdersProducts, "ID_ORDER", true));
            ordersProductsValueLabels["ID_PRODUCT"].DataBindings.Add(new Binding("Text", bindsourceOrdersProducts, "ID_PRODUCT", true));
            ordersProductsValueLabels["AMOUNT"].DataBindings.Add(new Binding("Text", bindsourceOrdersProducts, "AMOUNT", true));

            bindingNavigator.BindingSource = bindsourceOrdersProducts;
            conn.Close(); // Close Connection
        }

        public static void loadCustomerPhoto(PictureBox picbox)
        {
            string sql = "SELECT PHOTO FROM CUSTOMERS WHERE CUSTOMER_ID = @id;";
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                SqlParameter parameter = new SqlParameter("@id", SqlDbType.Int);
                parameter.Value = 28;
                command.Parameters.Add(parameter);

                if (conn.State == ConnectionState.Closed) {
                    conn.Open();
                }
                object value = command.ExecuteScalar();
                conn.Close();

                if (value != null)
                {
                    Image image = null;
                    byte[] data = (byte[])value;

                    if (data != null)
                    {
                        using (Stream ms = new MemoryStream())
                        {
                            ms.Write(data, 0, data.Length);
                            ms.Position = 0L;
                            image = new Bitmap(ms);
                            picbox.Image = image;
                            Console.WriteLine("IMAGE READ");
                        }
                    }
                }
            }
        }

        /// <exception cref="SqlException">Why it's thrown.</exception>
        public static bool addNewCustomer(Dictionary<String, TextBox> newCustomerTextboxes)  
        {
            string query = "INSERT INTO CUSTOMERS (LAST_NAME, FIRST_NAME, BIRTH_DATE, AGE, " +
                "AFM, DOY, ADDRESS, CITY, PHONE_NUMBER, COMMENTS) " +
                "VALUES(@LASTNAME_P, @FIRSTNAME_P, @BIRTHDATE_P, @AGE_P, @AFM_P, " +
                "@DOY_P, @ADDRESS_P, @CITY_P, @PHONENUMBER_P, @COMMENTS_P)";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@LASTNAME_P", newCustomerTextboxes["LAST_NAME"].Text);
            command.Parameters.AddWithValue("@FIRSTNAME_P", newCustomerTextboxes["FIRST_NAME"].Text);
            command.Parameters.AddWithValue("@BIRTHDATE_P", DateTime.Now.ToString("yyyy-MM-dd"));

            int age = Int32.Parse(newCustomerTextboxes["AGE"].Text);
            command.Parameters.AddWithValue("@AGE_P", newCustomerTextboxes["AGE"].Text);
            command.Parameters.AddWithValue("@AFM_P", newCustomerTextboxes["AFM"].Text);
            command.Parameters.AddWithValue("@DOY_P", newCustomerTextboxes["DOY"].Text);
            command.Parameters.AddWithValue("@ADDRESS_P", newCustomerTextboxes["ADDRESS"].Text);
            command.Parameters.AddWithValue("@CITY_P", newCustomerTextboxes["CITY"].Text);
            command.Parameters.AddWithValue("@PHONENUMBER_P", newCustomerTextboxes["PHONE_NUMBER"].Text);
            command.Parameters.AddWithValue("@COMMENTS_P", newCustomerTextboxes["COMMENTS"].Text);

            // Insert customer photo to database first
            insertCustomerPhoto(newCustomerTextboxes["PHOTO"].Text);

            conn.Open();

            try {
                command.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (SqlException e) {
                conn.Close();
                throw e;
            }
           
            /*
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}, {1}",
                    reader["tPatCulIntPatIDPk"], reader["tPatSFirstname"]));// etc
                }
            }
            finally
            {
                // Always call Close when done reading.
                reader.Close();
            }
            */

        }

        public static void updateOrdersTable()
        {
            SqlCommandBuilder comBuilder = new SqlCommandBuilder(adapterOrder);
            adapterOrder.Update(datasetOrder, "Orders_Table");
            Console.WriteLine("ORDERS TABLE UPDATED");
        }

        public static void updateProductsTable()
        {
            SqlCommandBuilder comBuilder = new SqlCommandBuilder(adapterProduct);
            adapterProduct.Update(datasetProducts, "Products_Table");
            Console.WriteLine("PRODUCTS TABLE UPDATED");
        }

        public static void updateOrdersProductsTable()
        {
            SqlCommandBuilder comBuilder = new SqlCommandBuilder(adapterOrdersProducts);
            adapterOrdersProducts.Update(datasetOrdersProducts, "OrdersProducts_Table");
            Console.WriteLine("ORDERS_PRODUCTS Table UPDATED");
        }

        public static SqlConnection GetConnection()
        {
            if (conn != null) {
                return conn;
            }
            Console.WriteLine("CONNECTION IS NOT OPENED YET");
            return null;
        }

        public static void CloseConnection()
        {
           conn.Close();
        }

        public static void insertCustomerPhoto(String path)
        {
            conn.Open();
            using (var command = conn.CreateCommand())
            {
                Image img = Image.FromFile(path.Trim());
                MemoryStream tmpStream = new MemoryStream();
                img.Save(tmpStream, ImageFormat.Png); // change to other format
                tmpStream.Seek(0, SeekOrigin.Begin);
                byte[] imgBytes = new byte[256000];
                tmpStream.Read(imgBytes, 0, 256000);

                command.CommandText = "INSERT INTO CUSTOMERS (PHOTO) VALUES (@image)";
                command.Parameters.AddWithValue("@image", imgBytes);
                command.ExecuteNonQuery();
            }
            conn.Close();
        }

        public static void deleteCustomer(String customer_id)
        {
            conn.Open();
            using (var command = conn.CreateCommand())
            {
                command.CommandText = "DELETE FROM CUSTOMERS WHERE CUSTOMER_ID = @param";
                command.Parameters.AddWithValue("@param", customer_id);
                command.ExecuteNonQuery();
            }
            conn.Close();
        }

        public static bool updateCustomer(Dictionary<String, TextBox> customerValueLabels, String customer_id)
        {
            conn.Open();
            using (var command = conn.CreateCommand())
            {
                command.CommandText = "UPDATE CUSTOMERS SET LAST_NAME = @LASTNAME_P, FIRST_NAME= @FIRSTNAME_P, BIRTH_DATE = @BIRTHDATE_P, " +
                    "AGE = @AGE_P, AFM = @AFM_P, DOY = @DOY_P, ADDRESS = @ADDRESS_P, CITY = @CITY_P, PHONE_NUMBER = @PHONENUMBER_P, COMMENTS = @COMMENTS_P" +
                    " WHERE CUSTOMER_ID = @IDPARAM";

                command.Parameters.AddWithValue("@LASTNAME_P", customerValueLabels["LAST_NAME"]);
                command.Parameters.AddWithValue("@FIRSTNAME_P", customerValueLabels["FIRST_NAME"]);
                command.Parameters.AddWithValue("@BIRTHDATE_P", customerValueLabels["BIRTH_DATE"]);
                command.Parameters.AddWithValue("@AGE_P", customerValueLabels["AGE"]);
                command.Parameters.AddWithValue("@AFM_P", customerValueLabels["AFM"]);
                command.Parameters.AddWithValue("@DOY_P", customerValueLabels["DOY"]);
                command.Parameters.AddWithValue("@ADDRESS_P", customerValueLabels["ADDRESS"]);
                command.Parameters.AddWithValue("@CITY_P", customerValueLabels["CITY"]);
                command.Parameters.AddWithValue("@PHONENUMBER_P", customerValueLabels["PHONE_NUMBER"]);
                command.Parameters.AddWithValue("@COMMENTS_P", customerValueLabels["COMMENTS"]);
                command.Parameters.AddWithValue("@IDPARAM", customer_id);

                try {
                    command.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (SqlException e) {
                    conn.Close();
                    throw e;
                } 
            }
        }

    }
}
