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
    public partial class UpdateOrdersProducts : Form
    {
        private BindingNavigator bindingNavigatorOrdersProducts;
        private Dictionary<String, Label> ordersProductsValueLabels;

        public UpdateOrdersProducts(Dictionary<String, Label> ordersProductsValueLabels1, BindingNavigator bindingNavigatorOrdersProducts1)
        {
            // Load application icon
            this.Icon = Properties.Resources.app;

            bindingNavigatorOrdersProducts = bindingNavigatorOrdersProducts1;
            ordersProductsValueLabels = ordersProductsValueLabels1;

            InitializeComponent();
            amount_textbox.Text = ordersProductsValueLabels1["AMOUNT"].Text;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            UpdateOrdersProductsController.updateOrdersProducts(amount_textbox, bindingNavigatorOrdersProducts, this, 
                int.Parse(ordersProductsValueLabels["ORDER_ID_F"].Text), int.Parse(ordersProductsValueLabels["PRODUCT_ID_F"].Text));
        }

        
    }
}
