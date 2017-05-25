using System;
using System.Windows.Forms;

namespace Digital_Storehouse.Controllers
{
    class ViewMessages
    {
        public static void AgeIsNotValid()
        {
            MessageBox.Show("Age field must be a valid integer value", "FORMAT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void CustomerAdded()
        {
            MessageBox.Show("Customer was successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ExceptionOccured(Exception e)
        {
            MessageBox.Show(e.ToString(), "SOMETHING WENT WRONG:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void CustomerUpdated()
        {
            MessageBox.Show("Customer was successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void FillRequiredFields()
        {
            MessageBox.Show("Please fill in all the required fields",
                "Required Field(s) are empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void NonIntegerAge()
        {
            MessageBox.Show("Please use a valid integer number for the 'AGE' field.",
                "Unaccepted input value for 'AGE' field", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void NonIntegerAfm()
        {
            MessageBox.Show("Please use a valid integer number for the 'AFM' field.",
                "Unaccepted input value for 'AFM' field", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void AfmExists()
        {
            MessageBox.Show("This AFM number already exists! AFM number should be unique, please try again.",
                "AFM already exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }





        public static DialogResult DeleteCustomerDialog()
        {
            return MessageBox.Show("Are you sure you want to delete this Customer?",
                "Deleting Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        public static DialogResult DeleteOrderDialog()
        {
            return MessageBox.Show("Are you sure you want to delete this Order?",
                "Deleting Order", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        public static DialogResult DeleteProductDialog()
        {
            return MessageBox.Show("Are you sure you want to delete this Order?",
                "Deleting Order", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        public static DialogResult DeleteRelationshipDialog()
        {
            return MessageBox.Show("Are you sure you want to delete this Order?",
                "Deleting Order", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }




        public static void OutOfScopeAge()
        {
            MessageBox.Show("Please use a proper age input",
                "Unaccepted input value for 'AGE' field", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void InvalidAfm()
        {
            MessageBox.Show("Please use a valid AFM number.",
                "This AFM number is not valid: AFM should be 9 digits", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void LastNameTooSmall()
        {
            MessageBox.Show("Last Name too short.",
                "Last Name should be at least 3 characters.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void FirstNameTooSmall()
        {
            MessageBox.Show("First Name too short.",
                "First Name should be at least 3 characters.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void OrderAdded()
        {
            MessageBox.Show("Order added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
