using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Storehouse.Controllers
{
    class ViewMessages
    {
        public static void ageIsNotValid()
        {
            MessageBox.Show("Age field must be a valid integer value", "FORMAT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void customerAdded()
        {
            MessageBox.Show("Customer was successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void exceptionOccured(Exception e)
        {
            MessageBox.Show(e.ToString(), "SOMETHING WENT WRONG:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }
}
