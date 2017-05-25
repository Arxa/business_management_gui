using Digital_Storehouse.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Digital_Storehouse.Daos;
using Digital_Storehouse.Views;

namespace Digital_Storehouse
{
    public partial class App : Form
    {
        protected static Dictionary<String, Label> CustomerLabels = new Dictionary<string, Label>();
        protected static Dictionary<String, Label> ProductLabels = new Dictionary<string, Label>();
        protected static Dictionary<String, Label> OrderLabels = new Dictionary<string, Label>();
        protected static Dictionary<String, Label> OrdersProductsLabels = new Dictionary<string, Label>();

        public App()
        {
            // Load application icon
            this.Icon = Properties.Resources.app;

            InitializeComponent();

            CustomerLabels["CUSTOMER_ID"] = customerId_value_label;
            CustomerLabels["LAST_NAME"] = lastName_value_label;
            CustomerLabels["FIRST_NAME"] = firstName_value_label;
            CustomerLabels["BIRTH_DATE"] = birthDate_value_label;
            CustomerLabels["AGE"] = age_value_label;
            CustomerLabels["AFM"] = afm_value_label;
            CustomerLabels["DOY"] = doy_value_label;
            CustomerLabels["ADDRESS"] = address_value_label;
            CustomerLabels["CITY"] = city_value_label;
            CustomerLabels["PHONE_NUMBER"] = phoneNumber_value_label;
            CustomerLabels["COMMENTS"] = comments_value_label;
            CustomerLabels["HAS_PHOTO"] = hasPhoto_label;

            ProductLabels["PRODUCT_ID"] = productId_value_label;
            ProductLabels["CATEGORY"] = category_value_label;
            ProductLabels["SELLING_PRICE"] = sellingPrice_value_label;
            ProductLabels["LABEL"] = label_value_label;
            ProductLabels["RESERVE"] = reserve_value_label;
            ProductLabels["MANUFACTURER"] = manufacturer_value_label;

            OrderLabels["ORDER_ID"] = orderId_value_label;
            OrderLabels["CUSTOMER_ID_F"] = customerId_F_label;
            OrderLabels["ORDER_DATE"] = orderDate_value_label;
            OrderLabels["PAYMENT_METHOD"] = paymentMethod_value_label;
            OrderLabels["DELIVERY_LOCATION"] = deliveryLocation_value_label;

            OrdersProductsLabels["PRODUCT_ID_F"] = productId_F_label;
            OrdersProductsLabels["ORDER_ID_F"] = orderId_F_label;
            OrdersProductsLabels["AMOUNT"] = amount_value_label;
        }

        private void App_Load(object sender, EventArgs e)
        {
            DatabaseConnection db = new DatabaseConnection(CustomerLabels, bindingNavigator_Customer, 
                ProductLabels, bindingNavigator_Products, OrderLabels, bindingNavigator_Orders, OrdersProductsLabels, bindingNavigator_OrdersProducts);    

            AppController.syncCustomersTab(AppDAO.getBindSourceCustomer(), CustomerLabels, pictureBox_customer,
                deleteCustomer_button, updateCustomer_button);

            AppController.syncProductsTab(AppDAO.getBindSourceProducts(), ProductLabels,
                deleteProduct_button, updateProduct_button);

            AppController.syncOrdersTab(AppDAO.getBindSourceOrders(), OrderLabels, 
                deleteOrder_button, updateOrder_button);

            AppController.syncOrdersProductsTab(AppDAO.getBindSourceOrdersProducts(), OrdersProductsLabels, 
                deleteRelationship_button, updateRelationship_button);

            
        }

       
        private void insertCustomer_button_Click(object sender, EventArgs e)
        {
            AppController.OpenNewCustomerForm(bindingNavigator_Customer);
        }

        

        private void deleteCustomer_button_Click(object sender, EventArgs e)
        {
            AppController.DeleteCustomer(CustomerLabels, bindingNavigator_Customer);

            AppController.syncCustomersTab(AppDAO.getBindSourceCustomer(), CustomerLabels, pictureBox_customer,
                deleteCustomer_button, updateCustomer_button);
        }

        private void updateCustomer_button_Click(object sender, EventArgs e)
        {
            AppController.OpenUpdateCustomerForm(CustomerLabels, pictureBox_customer, bindingNavigator_Customer);
        }


        private void customerId_value_label_TextChanged(object sender, EventArgs e)
        {
            AppController.syncCustomersTab(AppDAO.getBindSourceCustomer(), CustomerLabels, pictureBox_customer,
                deleteCustomer_button, updateCustomer_button);
        }

        private void deleteProduct_button_Click(object sender, EventArgs e)
        {
            AppController.DeleteProduct(ProductLabels, bindingNavigator_Products);
            AppController.syncProductsTab(AppDAO.getBindSourceProducts(), ProductLabels,
                deleteProduct_button, updateProduct_button);
        }

        private void deleteOrder_button_Click(object sender, EventArgs e)
        {
            AppController.DeleteOrder(OrderLabels, bindingNavigator_Orders);
            AppController.syncOrdersTab(AppDAO.getBindSourceOrders(), OrderLabels,
                deleteOrder_button, updateOrder_button);
        }

        private void deleteRelationship_button_Click(object sender, EventArgs e)
        {
            AppController.DeleteRelationship(OrdersProductsLabels, bindingNavigator_OrdersProducts);
            AppController.syncOrdersProductsTab(AppDAO.getBindSourceOrdersProducts(), OrdersProductsLabels,
                deleteRelationship_button, updateRelationship_button);
        }

        private void addOrder_button_Click(object sender, EventArgs e)
        {
            NewOrder form = new NewOrder(bindingNavigator_Orders);
            form.Show();
        }

        public static Dictionary<String, Label> GetCustomerLabels()
        {
            return CustomerLabels;
        }

        public static Dictionary<String, Label> GetOrderLabels()
        {
            return OrderLabels;
        }

        public static Dictionary<String, Label> GetProductLabels()
        {
            return ProductLabels;
        }

        public static Dictionary<String, Label> GetOrdersProductsLabels()
        {
            return OrdersProductsLabels;
        }

    }
}
