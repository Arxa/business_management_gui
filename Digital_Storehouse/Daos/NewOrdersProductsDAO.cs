using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Storehouse.Daos
{
    class NewOrdersProductsDAO : DatabaseConnection
    {

        public static List<String> getOrdersIds()
        {
            openConnectionIfClosed();

            List<String> customerIdsList = new List<string>();

            using (var command = Conn.CreateCommand())
            {
                command.CommandText = "SELECT ORDER_ID FROM ORDERS";
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

        public static List<String> getProductsIds()
        {
            openConnectionIfClosed();

            List<String> customerIdsList = new List<string>();

            using (var command = Conn.CreateCommand())
            {
                command.CommandText = "SELECT PRODUCT_ID FROM PRODUCTS";
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



        public static void addNewOrdersProducts(int orderId, int productId, float amount)
        {
            string query = "INSERT INTO ORDERS_PRODUCTS (ID_ORDER, ID_PRODUCT, AMOUNT) " +
                           "VALUES(@IDORDER_P, @IDPRODUCT_P, @AMOUNT_P)";

            SqlCommand command = new SqlCommand(query, Conn);

            command.Parameters.AddWithValue("@IDORDER_P", orderId);
            command.Parameters.AddWithValue("@IDPRODUCT_P", productId);
            command.Parameters.AddWithValue("@AMOUNT_P", amount);

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

        public static List<String> getOrderIdsInOrdersProductsTable()
        {
            openConnectionIfClosed();

            List<String> customerIdsList = new List<string>();

            using (var command = Conn.CreateCommand())
            {
                command.CommandText = "SELECT ID_ORDER FROM ORDERS_PRODUCTS";
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

        public static List<String> getProductIdsInOrdersProductsTable()
        {
            openConnectionIfClosed();

            List<String> customerIdsList = new List<string>();

            using (var command = Conn.CreateCommand())
            {
                command.CommandText = "SELECT ID_PRODUCT FROM ORDERS_PRODUCTS";
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

        public static bool checkIfKeyAlreadyExists(int orderId, int productId)
        {
            openConnectionIfClosed();
            
            using (var command = Conn.CreateCommand())
            {
                command.CommandText = "SELECT * FROM ORDERS_PRODUCTS WHERE ID_ORDER = @IDORDER_P AND ID_PRODUCT = @IDPRODUCT";
                command.Parameters.AddWithValue("@IDORDER_P", orderId);
                command.Parameters.AddWithValue("@IDPRODUCT", productId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Conn.Close();
                        return true;
                    }
                }
            }
            Conn.Close();
            return false;
        }
    }
}
