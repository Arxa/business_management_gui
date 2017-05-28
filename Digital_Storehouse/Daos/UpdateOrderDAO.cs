using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Storehouse.Daos
{
    class UpdateOrderDAO : DatabaseConnection
    {
        public static void updateOrder(DateTime orderDatePicker, int customerId, string paymentMethod, string deliveryLocation, int orderId)
        {
            string query = "UPDATE ORDERS SET ORDER_DATE = @ORDERDATE_P, CUSTOMER_ID = @CUSTOMERID_P, " +
                           "PAYMENT_METHOD = @PAYMENTMETHOD_P, DELIVERY_LOCATION = @DELIVERYLOCATION_P WHERE ORDER_ID = @ORDERID_P";

            SqlCommand command = new SqlCommand(query, Conn);

            command.Parameters.AddWithValue("@ORDERDATE_P", orderDatePicker);
            command.Parameters.AddWithValue("@CUSTOMERID_P", customerId);
            command.Parameters.AddWithValue("@PAYMENTMETHOD_P", paymentMethod);
            command.Parameters.AddWithValue("@DELIVERYLOCATION_P", deliveryLocation);
            command.Parameters.AddWithValue("@ORDERID_P", orderId);

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
