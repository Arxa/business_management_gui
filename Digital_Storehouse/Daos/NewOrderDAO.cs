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
        
        public static List<String> getCustomerIds()
        {
            openConnectionIfClosed();

            List<String> customerIdsList = new List<string>();

            using (var command = Conn.CreateCommand())
            {
                command.CommandText = "SELECT CUSTOMER_ID FROM CUSTOMERS";
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



        public static void addNewOrder(string deliveryLocation, string paymentMethod, DateTime orderDate, string customerId)
        {
            string query = "INSERT INTO ORDERS (ORDER_DATE, CUSTOMER_ID, PAYMENT_METHOD, DELIVERY_LOCATION) " +
                           "VALUES(@ORDERDATE_P, @CUSTOMERID_P, @PAYMENTMETHOD_P, @DELIVERYLOCATION_P)";

            SqlCommand command = new SqlCommand(query, Conn);

            command.Parameters.AddWithValue("@ORDERDATE_P", orderDate);
            command.Parameters.AddWithValue("@CUSTOMERID_P", customerId);
            command.Parameters.AddWithValue("@PAYMENTMETHOD_P", paymentMethod);
            command.Parameters.AddWithValue("@DELIVERYLOCATION_P", deliveryLocation);

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

        public static List<String> getCustomerIdsInOrdersProductsTable()
        {
            openConnectionIfClosed();

            List<String> customerIdsList = new List<string>();

            using (var command = Conn.CreateCommand())
            {
                command.CommandText = "SELECT CUSTOMER_ID FROM ORDERS";
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

    }
}
