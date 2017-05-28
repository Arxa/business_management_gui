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

namespace Digital_Storehouse.Views
{
    public partial class UpdateOrder : Form
    {
        private Dictionary<String, Label> orderValueLabels;
        private BindingNavigator bindingNavigator_Orders;

        public UpdateOrder(Dictionary<String, Label> orderValueLabels1, BindingNavigator ordersBindingNavigator1)
        {
            // Load application icon
            this.Icon = Properties.Resources.app;

            orderValueLabels = orderValueLabels1;
            bindingNavigator_Orders = ordersBindingNavigator1;

            InitializeComponent();
            initializeFields();
        }

        public void initializeFields()
        {
            orderDate_picker.Value = DateTime.Parse(orderValueLabels["ORDER_DATE"].Text);
            UpdateOrderController.fillCustomerIdCombobox(customerId_combobox);
            customerId_combobox.SelectedItem = orderValueLabels["CUSTOMER_ID_F"].Text;
            paymentMethod_combobox.SelectedItem = orderValueLabels["PAYMENT_METHOD"].Text;
            deliveryLocation_textbox.Text = orderValueLabels["DELIVERY_LOCATION"].Text;
        }


        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateOrderController.updateOrder(customerId_combobox,paymentMethod_combobox,deliveryLocation_textbox,
                orderDate_picker, bindingNavigator_Orders, this, Int32.Parse(orderValueLabels["ORDER_ID"].Text));
        }
    }
}
