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
        public NewCustomerDAO(Dictionary<string, Label> customerValueLabels, BindingNavigator bindingNavigator, Dictionary<string, Label> ProductValueLabels, BindingNavigator bindingNavigator_Products, Dictionary<string, Label> OrderValueLabels, BindingNavigator bindingNavigator_Orders, Dictionary<string, Label> OrderProductsValueLabels, BindingNavigator bindingNavigator_OrdersProducts) : base(customerValueLabels, bindingNavigator, ProductValueLabels, bindingNavigator_Products, OrderValueLabels, bindingNavigator_Orders, OrderProductsValueLabels, bindingNavigator_OrdersProducts)
        {
        }


        /// <exception cref="SqlException">Why it's thrown.</exception>
        public static string AddNewCustomer(Dictionary<String, MyTextBox> newCustomerTextboxes, DateTime birthDate)
        {
            string query = "INSERT INTO CUSTOMERS (LAST_NAME, FIRST_NAME, BIRTH_DATE, AGE, " +
                           "AFM, DOY, ADDRESS, CITY, PHONE_NUMBER, COMMENTS, PHOTO, HAS_PHOTO) " +
                           "VALUES(@LASTNAME_P, @FIRSTNAME_P, @BIRTHDATE_P, @AGE_P, @AFM_P, " +
                           "@DOY_P, @ADDRESS_P, @CITY_P, @PHONENUMBER_P, @COMMENTS_P, @PHOTO_P, @HASPHOTO_P)";

            SqlCommand command = new SqlCommand(query, Conn);

            command.Parameters.AddWithValue("@LASTNAME_P", newCustomerTextboxes["LAST_NAME"].Text);
            command.Parameters.AddWithValue("@FIRSTNAME_P", newCustomerTextboxes["FIRST_NAME"].Text);

            command.Parameters.AddWithValue("@BIRTHDATE_P", birthDate);

            if (newCustomerTextboxes["AGE"].Text.Length > 0)
            {
                int age = Int32.Parse(newCustomerTextboxes["AGE"].Text);
                command.Parameters.AddWithValue("@AGE_P", age);
            }
            else
            {
                command.Parameters.AddWithValue("@AGE_P", 0);
            }

            command.Parameters.AddWithValue("@AFM_P", newCustomerTextboxes["AFM"].Text);
            command.Parameters.AddWithValue("@DOY_P", newCustomerTextboxes["DOY"].Text);
            command.Parameters.AddWithValue("@ADDRESS_P", newCustomerTextboxes["ADDRESS"].Text);
            command.Parameters.AddWithValue("@CITY_P", newCustomerTextboxes["CITY"].Text);
            command.Parameters.AddWithValue("@PHONENUMBER_P", newCustomerTextboxes["PHONE_NUMBER"].Text);
            command.Parameters.AddWithValue("@COMMENTS_P", newCustomerTextboxes["COMMENTS"].Text);

            // Bind image
            if (newCustomerTextboxes["PHOTO"].Text.Equals(Container.EMPTY))
            {
                byte[] bytes = GetImageBytesFromImage(Resources.no_photo);
                command.Parameters.AddWithValue("@PHOTO_P", bytes);
                command.Parameters.AddWithValue("@HASPHOTO_P", Container.HAS_PHOTO_FALSE);
            }
            else
            {
                byte[] bytes = GetImageBytesFromPath(newCustomerTextboxes["PHOTO"].Text.Trim());
                command.Parameters.AddWithValue("@PHOTO_P", bytes);
                command.Parameters.AddWithValue("@HASPHOTO_P", Container.HAS_PHOTO_TRUE);
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
            catch (SqlException e)
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
