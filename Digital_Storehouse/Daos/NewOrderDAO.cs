using Digital_Storehouse.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Digital_Storehouse.Properties;

namespace Digital_Storehouse.Daos
{
    class NewOrderDAO : DatabaseConnection
    {
        public NewOrderDAO(Dictionary<string, Label> customerValueLabels, BindingNavigator bindingNavigator, Dictionary<string, Label> ProductValueLabels, BindingNavigator bindingNavigator_Products, Dictionary<string, Label> OrderValueLabels, BindingNavigator bindingNavigator_Orders, Dictionary<string, Label> OrderProductsValueLabels, BindingNavigator bindingNavigator_OrdersProducts) : base(customerValueLabels, bindingNavigator, ProductValueLabels, bindingNavigator_Products, OrderValueLabels, bindingNavigator_Orders, OrderProductsValueLabels, bindingNavigator_OrdersProducts)
        {
        }

        public static List<String> getAllCustomerIds()
        {
            openConnectionIfClosed();

            List<String> customerIdsList = new List<string>();

            using (var command = Conn.CreateCommand())
            {
                command.CommandText = "SELECT CUSTOMER_ID FROM @TABLE";
                command.Parameters.AddWithValue("@TABLE", "CUSTOMERS");
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customerIdsList.Add(reader[0].ToString());
                    }
                }
            }
            Conn.Close();

            return customerIdsList;
        }



        public static void addNewOrder(Dictionary<String, MyTextBox> newOrderTextboxes, DateTime orderDate, string customerId)
        {
            string query = "INSERT INTO ORDERS (ORDER_DATE, CUSTOMER_ID, PAYMENT_METHOD, DELIVERY_LOCATION " +
                           "VALUES(@ORDERDATE_P, @CUSTOMERID_P, @PAYMENTMETHOD_P, @DELIVERYLOCATION_P)";

            SqlCommand command = new SqlCommand(query, Conn);

            command.Parameters.AddWithValue("@ORDERDATE_P", orderDate);
            command.Parameters.AddWithValue("@CUSTOMERID_P", customerId);
            command.Parameters.AddWithValue("@PAYMENTMETHOD_P", newOrderTextboxes["PAYMENT_METHOD"].Text);
            command.Parameters.AddWithValue("@DELIVERYLOCATION_P", newOrderTextboxes["DELIVERY_LOCATION"].Text);

            openConnectionIfClosed();

            try
            {
                command.ExecuteNonQuery();
                Conn.Close();
            }
            catch (SqlException e)
            {
                Conn.Close();
                Controllers.ViewMessages.ExceptionOccured(e);
            }
        }

        
    }
}
