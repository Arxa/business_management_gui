using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Digital_Storehouse.Daos;
using Digital_Storehouse.Models;
using Digital_Storehouse.Views;

namespace Digital_Storehouse.Controllers
{
    public class UpdateCustomerController
    {
        private static DatabaseConnection db = new DatabaseConnection();


        public static void UpdateCustomer(PictureBox pictureBox, Dictionary<String, MyTextBox> updateCustomerTextboxes, Dictionary<String, Label> customerValueLabels,
            PictureBox customerPictureBox, RichTextBox comments_richTextbox, BindingNavigator bindingNavigatorCustomers, UpdateCustomer updateCustomerForm)
        {
            if (!NewCustomerController.ValidateFields(updateCustomerTextboxes, !updateCustomerTextboxes["AFM"].Text.Equals(customerValueLabels["AFM"].Text)))
            {
                return;
            }

            // Refresh the Binding Navigator if customer was updated succesfully
            try
            {
                UpdateCustomerDAO.UpdateCustomer(pictureBox, comments_richTextbox, updateCustomerTextboxes, Int32.Parse(customerValueLabels["CUSTOMER_ID"].Text));

                int currentPage = bindingNavigatorCustomers.BindingSource.Position;
                foreach (KeyValuePair<String, Label> entry in App.GetCustomerLabels())
                {
                    entry.Value.DataBindings.Clear();
                }

                db.BindCustomerData(App.GetCustomerLabels(), App.getCommentsRichTextbox(), bindingNavigatorCustomers);
                bindingNavigatorCustomers.BindingSource.Position = currentPage;

                AppDAO.LoadCustomerPhoto(customerPictureBox, Int32.Parse(customerValueLabels["CUSTOMER_ID"].Text));

                // Updated!
                updateCustomerForm.Close();
            }
            catch (SqlException e)
            {
                ViewMessages.ExceptionOccured(e);
            }
        }

        public static void ShowPhotoDialogChooser(OpenFileDialog dialog, TextBox photoTextbox)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dialog.Filter =
                    "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                dialog.InitialDirectory = @"C:\";
                dialog.Title = "Select New Customer's photo";
                photoTextbox.Text = dialog.FileName;
            }
        }


        public static void removePhoto(PictureBox pictureBox1)
        {
            pictureBox1.Image = Properties.Resources.no_photo;
        }

        public static void loadPhotoAfterDialog(PictureBox pictureBox, string photoLabelPathText)
        {
            if (!photoLabelPathText.Equals(Container.EMPTY))
            {
                pictureBox.Image = Image.FromFile(photoLabelPathText);
            }

        }
    }
}
