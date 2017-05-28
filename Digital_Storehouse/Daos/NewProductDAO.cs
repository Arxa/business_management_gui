using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Storehouse.Daos
{
    class NewProductDAO : DatabaseConnection
    {
        public static void addNewProduct(string label, string category, int reserve, float selling_price, string manufacturer)
        {
            string query = "INSERT INTO PRODUCTS (LABEL, CATEGORY, RESERVE, SELLING_PRICE, MANUFACTURER) " +
                           "VALUES(@LABEL_P, @CATEGORY_P, @RESERVE_P, @SELLINGPRICE_P, @MANUFACTURER_P)";

            SqlCommand command = new SqlCommand(query, Conn);

            command.Parameters.AddWithValue("@LABEL_P", label);
            command.Parameters.AddWithValue("@CATEGORY_P", category);
            command.Parameters.AddWithValue("@RESERVE_P", reserve);
            command.Parameters.AddWithValue("@SELLINGPRICE_P", selling_price);
            command.Parameters.AddWithValue("@MANUFACTURER_P", manufacturer);

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
