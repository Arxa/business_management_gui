using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Storehouse.Daos
{
    class UpdateOrdersProductsDAO : DatabaseConnection
    {
        public static void updateOrdersProducts(float amount, int idOrder, int idProduct)
        {
            string query = "UPDATE ORDERS_PRODUCTS SET AMOUNT = @AMOUNT_P WHERE ID_ORDER = @IDORDER_P AND ID_PRODUCT = @IDPRODUCT_P";

            SqlCommand command = new SqlCommand(query, Conn);

            command.Parameters.AddWithValue("@AMOUNT_P", amount);
            command.Parameters.AddWithValue("@IDORDER_P", idOrder);
            command.Parameters.AddWithValue("@IDPRODUCT_P", idProduct);
            
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
