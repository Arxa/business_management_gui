using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Storehouse.Daos
{
    public class AppDAO : DatabaseConnection
    {
        
        public static void LoadCustomerPhoto(PictureBox picbox, int customerId)
        {
            string sql = "SELECT PHOTO FROM CUSTOMERS WHERE CUSTOMER_ID = @id;";
            using (SqlCommand command = new SqlCommand(sql, Conn))
            {
                command.Parameters.AddWithValue("@id", customerId);

                openConnectionIfClosed();

                object value = command.ExecuteScalar();
                Conn.Close();

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
                        }
                    }
                }
            }
        }

        public static void DeleteCustomer(int customerId)
        {
            openConnectionIfClosed();

            using (var command = Conn.CreateCommand())
            {
                command.CommandText = "DELETE FROM CUSTOMERS WHERE CUSTOMER_ID = @param";
                command.Parameters.AddWithValue("@param", customerId);
                command.ExecuteNonQuery();
            }
            Conn.Close();
        }

        public static void DeleteOrder(int ordeId)
        {
            openConnectionIfClosed();

            using (var command = Conn.CreateCommand())
            {
                command.CommandText = "DELETE FROM ORDERS WHERE ORDER_ID = @param";
                command.Parameters.AddWithValue("@param", ordeId);
                command.ExecuteNonQuery();
            }
            Conn.Close();
        }

        public static void DeleteProduct(int productId)
        {
            openConnectionIfClosed();

            using (var command = Conn.CreateCommand())
            {
                command.CommandText = "DELETE FROM PRODUCTS WHERE PRODUCT_ID = @param";
                command.Parameters.AddWithValue("@param", productId);
                command.ExecuteNonQuery();
            }
            Conn.Close();
        }

        public static void DeleteRelationship(int idOrder)
        {
            openConnectionIfClosed();

            using (var command = Conn.CreateCommand())
            {
                command.CommandText = "DELETE FROM ORDERS_PRODUCTS WHERE ID_ORDER = @param";
                command.Parameters.AddWithValue("@param", idOrder);
                command.ExecuteNonQuery();
            }
            Conn.Close();
        }


        
   



    }
}
