using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Storehouse.Models
{
    public class MyTextBox : System.Windows.Forms.TextBox
    {
        private bool required;

        public MyTextBox()
        {
            
        }

        public MyTextBox(bool state)
        {
            required = state;
        }

        public bool isRequired()
        {
            return required;
        }

        public void setRequired(bool state)
        {
            required = state;
        }
    }
}
