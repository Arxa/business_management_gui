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
       
        public static bool UpdateCustomer(PictureBox pictureBox, RichTextBox comments_richTextbox, DateTime birthDate, Dictionary<String, MyTextBox> updateCustomerTextboxes, int customerId)
        {
            using (var command = Conn.CreateCommand())
            {
                command.CommandText = "UPDATE CUSTOMERS SET LAST_NAME = @LASTNAME_P, FIRST_NAME= @FIRSTNAME_P, BIRTH_DATE = @BIRTHDATE_P, " +
                                      "AFM = @AFM_P, DOY = @DOY_P, ADDRESS = @ADDRESS_P, CITY = @CITY_P, PHONE_NUMBER = @PHONENUMBER_P, " +
                                      "COMMENTS = @COMMENTS_P, PHOTO = @PHOTO_P WHERE CUSTOMER_ID = @IDPARAM";

                command.Parameters.AddWithValue("@LASTNAME_P", updateCustomerTextboxes["LAST_NAME"].Text);
                command.Parameters.AddWithValue("@FIRSTNAME_P", updateCustomerTextboxes["FIRST_NAME"].Text);

                command.Parameters.AddWithValue("@BIRTHDATE_P", birthDate);
                command.Parameters.AddWithValue("@AFM_P", updateCustomerTextboxes["AFM"].Text);
                command.Parameters.AddWithValue("@DOY_P", updateCustomerTextboxes["DOY"].Text);
                command.Parameters.AddWithValue("@ADDRESS_P", updateCustomerTextboxes["ADDRESS"].Text);
                command.Parameters.AddWithValue("@CITY_P", updateCustomerTextboxes["CITY"].Text);
                command.Parameters.AddWithValue("@PHONENUMBER_P", updateCustomerTextboxes["PHONE_NUMBER"].Text);
                command.Parameters.AddWithValue("@COMMENTS_P", comments_richTextbox.Text);
                command.Parameters.AddWithValue("@IDPARAM", customerId);

                byte[] bytes = GetImageBytesFromImage(pictureBox.Image);
                command.Parameters.AddWithValue("@PHOTO_P", bytes);
                
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
