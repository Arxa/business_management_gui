using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Storehouse.Daos
{
    class UpdateProductDAO : DatabaseConnection
    {
        public static void updateProduct(string label, string category, int reserve, float selling_price, string manufacturer, int productId)
        {
            string query = "UPDATE PRODUCTS SET LABEL = @LABEL_P, CATEGORY = @CATEGORY_P, RESERVE = @RESERVE_P, SELLING_PRICE = @SELLINGPRICE_P, " +
                           "MANUFACTURER = @MANUFACTURER_P WHERE PRODUCT_ID = @PRODUCTID_P";

            SqlCommand command = new SqlCommand(query, Conn);

            command.Parameters.AddWithValue("@LABEL_P", label);
            command.Parameters.AddWithValue("@CATEGORY_P", category);
            command.Parameters.AddWithValue("@RESERVE_P", reserve);
            command.Parameters.AddWithValue("@SELLINGPRICE_P", selling_price);
            command.Parameters.AddWithValue("@MANUFACTURER_P", manufacturer);
            command.Parameters.AddWithValue("@PRODUCTID_P", productId);

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
