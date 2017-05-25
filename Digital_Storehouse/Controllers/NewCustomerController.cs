﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Digital_Storehouse.Daos;
using Digital_Storehouse.Models;
using Digital_Storehouse.Views;


namespace Digital_Storehouse.Controllers
{
    public class NewCustomerController
    {
        public static bool ValidateFields(Dictionary<string, MyTextBox> newCustomerTextboxes)
        {

            // Check for AFM input
            string afm = newCustomerTextboxes["AFM"].Text.Trim();
            if (!Int32.TryParse(afm, out int n))
            {
                ViewMessages.NonIntegerAfm();
                return false;
            }

            if (afm.Length != 9)
            {
                ViewMessages.InvalidAfm();
                return false;
            }

            if (NewCustomerDAO.afmExists(afm))
            {
                ViewMessages.AfmExists();
                return false;
            }



            //Validate Last Name
            if (newCustomerTextboxes["LAST_NAME"].Text.Trim().Length < 3)
            {
                ViewMessages.LastNameTooSmall();
                return false;
            }

            //Validate First Name
            if (newCustomerTextboxes["FIRST_NAME"].Text.Trim().Length < 3)
            {
                ViewMessages.FirstNameTooSmall();
                return false;
            }

            // Check for AGE input
            if (!Int32.TryParse(newCustomerTextboxes["AGE"].Text.Trim(), out n) && newCustomerTextboxes["AGE"].Text.Trim().Length > 0)
            {
                ViewMessages.NonIntegerAge();
                return false;
            }

            if (n < 0 || n > 150)
            {
                ViewMessages.OutOfScopeAge();
                return false;
            }

            return true;
        }

        public static void AddNewCustomer(Dictionary<string, MyTextBox> newCustomerTextboxes, DateTime birthDate,
            BindingNavigator bindingNavigatorCustomers, NewCustomer newCustomerForm)
        {
            if (!ValidateFields(newCustomerTextboxes))
            {
                return;
            }

            // Refresh the Binding Navigator if customer was added succesfully
            try
            {
                int last_page = bindingNavigatorCustomers.BindingSource.Count;

                // TODO change this
                string id = NewCustomerDAO.AddNewCustomer(newCustomerTextboxes, birthDate);

                foreach (KeyValuePair<string, Label> entry in App.GetCustomerLabels())
                {
                    entry.Value.DataBindings.Clear();
                }

                AppDAO.BindCustomerData(App.GetCustomerLabels(), bindingNavigatorCustomers);

                bindingNavigatorCustomers.BindingSource.Position = last_page;

                ViewMessages.CustomerAdded();
                newCustomerForm.Close();
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
                dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                dialog.InitialDirectory = @"C:\";
                dialog.Title = "Select New Customer's photo";
                photoTextbox.Text = dialog.FileName;
            }
        }

        public static void syncNewCustomerForm(PictureBox pictureBox, Button removePhotoButton, MyTextBox photoTextBox)
        {
            if (photoTextBox.Text.Equals(Container.EMPTY))
            {
                pictureBox.Image = null;
                removePhotoButton.Enabled = false;
                return;
            }
            removePhotoButton.Enabled = true;
        }

        public static void removePhoto(PictureBox pictureBox1)
        {
            pictureBox1.Image = null;
        }
 
    }
}