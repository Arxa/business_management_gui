using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Digital_Storehouse.Models;
using Digital_Storehouse.Properties;
using Microsoft.Win32.SafeHandles;

namespace Digital_Storehouse.Daos
{
    public class NewCustomerDAO : DatabaseConnection
    {
        public NewCustomerDAO()
        {
        }


        /// <exception cref="SqlException">Why it's thrown.</exception>
        public static string AddNewCustomer(Dictionary<String, MyTextBox> newCustomerTextboxes, DateTime birthDate, RichTextBox comments_richTextbox)
        {
            string query = "INSERT INTO CUSTOMERS (LAST_NAME, FIRST_NAME, BIRTH_DATE, " +
                           "AFM, DOY, ADDRESS, CITY, PHONE_NUMBER, COMMENTS, PHOTO) " +
                           "VALUES(@LASTNAME_P, @FIRSTNAME_P, @BIRTHDATE_P, @AFM_P, " +
                           "@DOY_P, @ADDRESS_P, @CITY_P, @PHONENUMBER_P, @COMMENTS_P, @PHOTO_P)";

            SqlCommand command = new SqlCommand(query, Conn);

            command.Parameters.AddWithValue("@LASTNAME_P", newCustomerTextboxes["LAST_NAME"].Text);
            command.Parameters.AddWithValue("@FIRSTNAME_P", newCustomerTextboxes["FIRST_NAME"].Text);

            command.Parameters.AddWithValue("@BIRTHDATE_P", birthDate);
            command.Parameters.AddWithValue("@AFM_P", newCustomerTextboxes["AFM"].Text);
            command.Parameters.AddWithValue("@DOY_P", newCustomerTextboxes["DOY"].Text);
            command.Parameters.AddWithValue("@ADDRESS_P", newCustomerTextboxes["ADDRESS"].Text);
            command.Parameters.AddWithValue("@CITY_P", newCustomerTextboxes["CITY"].Text);
            command.Parameters.AddWithValue("@PHONENUMBER_P", newCustomerTextboxes["PHONE_NUMBER"].Text);
            command.Parameters.AddWithValue("@COMMENTS_P", comments_richTextbox.Text);

            // Bind image
            if (newCustomerTextboxes["PHOTO"].Text.Equals(Container.EMPTY))
            {
                byte[] bytes = GetImageBytesFromImage(Resources.no_photo);
                command.Parameters.AddWithValue("@PHOTO_P", bytes);
            }
            else
            {
                byte[] bytes = GetImageBytesFromPath(newCustomerTextboxes["PHOTO"].Text.Trim());
                command.Parameters.AddWithValue("@PHOTO_P", bytes);  
            }

            openConnectionIfClosed();

            try
            {
                command.ExecuteNonQuery();
                Conn.Close();

                Conn.Open();
                string query2 = "SELECT CUSTOMER_ID FROM CUSTOMERS WHERE AFM = @AFM_P";
                SqlCommand command2 = new SqlCommand(query2, Conn);
                command2.Parameters.AddWithValue("@AFM_P", newCustomerTextboxes["AFM"].Text);
                string id_added = Convert.ToString(command2.ExecuteScalar());
                Conn.Close();
                return id_added;

            }
            catch (SqlException)
            {
                Conn.Close();
                return Container.SELECT_FAILURE;
            }
        }

        public static bool afmExists(string afm)
        {
            openConnectionIfClosed();

            int rowsAffected;
            using (var command = Conn.CreateCommand())
            {
                command.CommandText = "SELECT COUNT(*) FROM CUSTOMERS WHERE AFM = @AFM_P";
                command.Parameters.AddWithValue("@AFM_P", afm);
                rowsAffected = (int)command.ExecuteScalar();
            }
            Conn.Close();

            return rowsAffected > 0;
        }
    }
}
