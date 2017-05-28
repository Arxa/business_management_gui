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
    public partial class UpdateProduct : Form
    {
        private BindingNavigator bindingNavigator_Products;
        private Dictionary<String, TextBox> updatedProductValueLabels;
        private int productId;

        public UpdateProduct(Dictionary<String, Label> productValueLabels, BindingNavigator bindingNavigator_Products1)
        {
            // Load application icon
            this.Icon = Properties.Resources.app;

            bindingNavigator_Products = bindingNavigator_Products1;
            InitializeComponent();
            initializeFields(productValueLabels); 
        }

        public void initializeFields(Dictionary<String, Label> productValueLabels)
        {
            updatedProductValueLabels = new Dictionary<String, TextBox>();

            category_textbox.Text = productValueLabels["CATEGORY"].Text;
            updatedProductValueLabels["CATEGORY"] = category_textbox;

            label_textbox.Text = productValueLabels["LABEL"].Text;
            updatedProductValueLabels["LABEL"] = label_textbox;

            reserve_textbox.Text = productValueLabels["RESERVE"].Text;
            updatedProductValueLabels["RESERVE"] = reserve_textbox;

            manufacturer_textbox.Text = productValueLabels["MANUFACTURER"].Text;
            updatedProductValueLabels["MANUFACTURER"] = manufacturer_textbox;

            sellingPrice_textbox.Text = productValueLabels["SELLING_PRICE"].Text;
            updatedProductValueLabels["SELLING_PRICE"] = sellingPrice_textbox;

            productId = int.Parse(productValueLabels["PRODUCT_ID"].Text);
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            UpdateProductController.updateProduct(updatedProductValueLabels, bindingNavigator_Products, this, productId);
        }
    }
}
