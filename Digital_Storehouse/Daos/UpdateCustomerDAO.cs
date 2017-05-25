using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Digital_Storehouse.Models;
using Digital_Storehouse.Properties;

namespace Digital_Storehouse.Daos
{
    public class UpdateCustomerDAO : DatabaseConnection
    {
        public UpdateCustomerDAO(Dictionary<string, Label> customerValueLabels, BindingNavigator bindingNavigator, Dictionary<string, Label> ProductValueLabels, BindingNavigator bindingNavigator_Products, Dictionary<string, Label> OrderValueLabels, BindingNavigator bindingNavigator_Orders, Dictionary<string, Label> OrderProductsValueLabels, BindingNavigator bindingNavigator_OrdersProducts) : base(customerValueLabels, bindingNavigator, ProductValueLabels, bindingNavigator_Products, OrderValueLabels, bindingNavigator_Orders, OrderProductsValueLabels, bindingNavigator_OrdersProducts)
        {
        }

        public static bool UpdateCustomer(Dictionary<String, MyTextBox> updateCustomerTextboxes, int customerId)
        {
            using (var command = Conn.CreateCommand())
            {
                command.CommandText = "UPDATE CUSTOMERS SET LAST_NAME = @LASTNAME_P, FIRST_NAME= @FIRSTNAME_P, BIRTH_DATE = @BIRTHDATE_P, " +
                                      "AGE = @AGE_P, AFM = @AFM_P, DOY = @DOY_P, ADDRESS = @ADDRESS_P, CITY = @CITY_P, PHONE_NUMBER = @PHONENUMBER_P, " +
                                      "COMMENTS = @COMMENTS_P, HAS_PHOTO = @HASPHOTO_P, PHOTO = @PHOTO_P WHERE CUSTOMER_ID = @IDPARAM";

                command.Parameters.AddWithValue("@LASTNAME_P", updateCustomerTextboxes["LAST_NAME"].Text);
                command.Parameters.AddWithValue("@FIRSTNAME_P", updateCustomerTextboxes["FIRST_NAME"].Text);

                DateTime birthdate = new DateTime(2017, 01, 22);
                command.Parameters.AddWithValue("@BIRTHDATE_P", birthdate);

                int age = Int32.Parse(updateCustomerTextboxes["AGE"].Text);
                command.Parameters.AddWithValue("@AGE_P", age);

                command.Parameters.AddWithValue("@AFM_P", updateCustomerTextboxes["AFM"].Text);
                command.Parameters.AddWithValue("@DOY_P", updateCustomerTextboxes["DOY"].Text);
                command.Parameters.AddWithValue("@ADDRESS_P", updateCustomerTextboxes["ADDRESS"].Text);
                command.Parameters.AddWithValue("@CITY_P", updateCustomerTextboxes["CITY"].Text);
                command.Parameters.AddWithValue("@PHONENUMBER_P", updateCustomerTextboxes["PHONE_NUMBER"].Text);
                command.Parameters.AddWithValue("@COMMENTS_P", updateCustomerTextboxes["COMMENTS"].Text);
                command.Parameters.AddWithValue("@IDPARAM", customerId);

                /*
                *Check if photo update is required. 
                * If user has updated the photo, the textbox's test 
                * should be equal to the new path rather than the initial "Customer's Photo"
                */
                if (!updateCustomerTextboxes["PHOTO"].Text.Equals(Container.EMPTY))
                {
                    byte[] bytes = GetImageBytesFromPath(updateCustomerTextboxes["PHOTO"].Text.Trim());
                    command.Parameters.AddWithValue("@PHOTO_P", bytes);
                    command.Parameters.AddWithValue("@HASPHOTO_P", Container.HAS_PHOTO_TRUE);
                }
                else
                {

                    byte[] bytes = GetImageBytesFromImage(Resources.no_photo);
                    command.Parameters.AddWithValue("@PHOTO_P", bytes);
                    command.Parameters.AddWithValue("@HASPHOTO_P", Container.HAS_PHOTO_FALSE);
                    command.ExecuteNonQuery();
                }


                openConnectionIfClosed();
                try
                {
                    command.ExecuteNonQuery();
                    Conn.Close();
                    return true;
                }
                catch (SqlException e)
                {
                    Conn.Close();
                    throw e;
                }
            }
        }


        
    }
}
