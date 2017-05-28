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
    public partial class NewOrdersProducts : Form
    {
        private static BindingNavigator bindingNavigatorOrdersProducts;

        public NewOrdersProducts(BindingNavigator bindingNavigatorOrdersProducts1)
        {
            // Load application icon
            this.Icon = Properties.Resources.app;

            bindingNavigatorOrdersProducts = bindingNavigatorOrdersProducts1;
            InitializeComponent();
        }

        private void NewOrdersProducts_Load(object sender, EventArgs e)
        {
            NewOrdersProductsController.fillcomboboxes(orderId_combobox, productId_combobox);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addRelationship_button_Click(object sender, EventArgs e)
        { 
            NewOrdersProductsController.addNewOrdersProducts(amount_textbox, orderId_combobox, productId_combobox, bindingNavigatorOrdersProducts, this);

        }
    }
}
