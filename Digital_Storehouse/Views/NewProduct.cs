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
    public partial class NewProduct : Form
    {
        private static BindingNavigator bindingNavigatorProducts;
        private static Dictionary<String, TextBox> newProductTextboxes = new Dictionary<string, TextBox>();

        public NewProduct(BindingNavigator bindingNavigatorOrders1)
        {
            // Load application icon
            this.Icon = Properties.Resources.app;

            bindingNavigatorProducts = bindingNavigatorOrders1;
            InitializeComponent();

            newProductTextboxes["LABEL"] = label_textbox;
            newProductTextboxes["CATEGORY"] = category_textbox;
            newProductTextboxes["RESERVE"] = reserve_textbox;
            newProductTextboxes["SELLING_PRICE"] = sellingPrice_textbox;
            newProductTextboxes["MANUFACTURER"] = manufacturer_textbox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewProductController.addNewProduct(newProductTextboxes, bindingNavigatorProducts, this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
