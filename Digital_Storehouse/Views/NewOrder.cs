using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Digital_Storehouse.Controllers;
using Digital_Storehouse.Models;

namespace Digital_Storehouse.Views
{
    public partial class NewOrder : Form
    {
        private static Dictionary<String, MyTextBox> newOrderTextboxes = new Dictionary<String, MyTextBox>();
        private static BindingNavigator bindingNavigatorOrders;

        public NewOrder(BindingNavigator bindingNavigatorOrders1)
        {
            bindingNavigatorOrders = bindingNavigatorOrders1;

            InitializeComponent();
            NewOrderController.fillCustomerIdCombobox(customerId_F_combobox);

            newOrderTextboxes["PAYMENT_METHOD"] = paymentMethod_textbox;
            newOrderTextboxes["DELIVERY_LOCATION"] = deliveryLocation_textbox;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addOrder_button_Click(object sender, EventArgs e)
        {
            NewOrderController.addNewOrder(newOrderTextboxes, orderDate_picker, customerId_F_combobox, bindingNavigatorOrders, this);
        }
    }
}
