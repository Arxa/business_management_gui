using Digital_Storehouse.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Digital_Storehouse.Daos;
using Digital_Storehouse.Views;
using System.Threading;
using Microsoft.Reporting.WinForms;
using System.Drawing;

namespace Digital_Storehouse
{
    public partial class App : Form
    {
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

        protected static Dictionary<String, Label> CustomerLabels = new Dictionary<string, Label>();
        protected static Dictionary<String, Label> ProductLabels = new Dictionary<string, Label>();
        protected static Dictionary<String, Label> OrderLabels = new Dictionary<string, Label>();
        protected static Dictionary<String, Label> OrdersProductsLabels = new Dictionary<string, Label>();

        private static RichTextBox commentsRichTextBoxGlobal;
        private DataGridViewTextBoxColumn totalColumn = new DataGridViewTextBoxColumn();
        
        private static DatabaseConnection db;

        public App()
        { 
            // Load application icon
            this.Icon = Properties.Resources.app;
            totalColumn.HeaderText = Models.Container.TOTAL_COLUMN_NAME;

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
            commentsRichTextBoxGlobal = comments_richTextbox;

            ProductLabels["PRODUCT_ID"] = productId_value_label;
            ProductLabels["CATEGORY"] = category_value_label;
            ProductLabels["SELLING_PRICE"] = sellingPrice_value_label;
            ProductLabels["LABEL"] = label_value_label;
            ProductLabels["RESERVE"] = reserve_value_label;
            ProductLabels["MANUFACTURER"] = manufacturer_value_label;

            OrderLabels["ORDER_ID"] = orderId_value_label;
            OrderLabels["CUSTOMER_ID_F"] = customerId_F_value_label;
            OrderLabels["ORDER_DATE"] = orderDate_value_label;
            OrderLabels["PAYMENT_METHOD"] = paymentMethod_value_label;
            OrderLabels["DELIVERY_LOCATION"] = deliveryLocation_value_label;

            OrdersProductsLabels["PRODUCT_ID_F"] = productId_F_value_label;
            OrdersProductsLabels["ORDER_ID_F"] = orderId_F_value_label;
            OrdersProductsLabels["AMOUNT"] = amount_value_label;

            db = new DatabaseConnection();

            toolTip1.SetToolTip(pictureBox1, Models.Container.PRINT_ICON_TOOLTIP);

        }

        


        private void App_Load(object sender, EventArgs e)
        {
            db.BindCustomerData(CustomerLabels, commentsRichTextBoxGlobal, bindingNavigator_Customer);
            db.BindProductsData(ProductLabels, bindingNavigator_Products);
            db.BindOrderData(OrderLabels, bindingNavigator_Orders);
            db.BindOrdersProductsData(OrdersProductsLabels, bindingNavigator_OrdersProducts);

            NewOrderController.fillCustomerIdCombobox(customerIds_combobox);
            
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
            AppController.DeleteCustomer(CustomerLabels, comments_richTextbox, bindingNavigator_Customer);

            AppController.syncCustomersTab(AppDAO.getBindSourceCustomer(), CustomerLabels, pictureBox_customer,
                deleteCustomer_button, updateCustomer_button);
        }

        private void updateCustomer_button_Click(object sender, EventArgs e)
        {
            AppController.OpenUpdateCustomerForm(CustomerLabels, pictureBox_customer, comments_richTextbox, bindingNavigator_Customer);
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

        private void updateOrder_button_Click(object sender, EventArgs e)
        {
            UpdateOrder form = new UpdateOrder(OrderLabels,bindingNavigator_Orders);
            form.Show();
        }

        private void addProduct_button_Click(object sender, EventArgs e)
        {
            NewProduct form = new NewProduct(bindingNavigator_Products);
            form.Show();
        }

        private void updateRelationship_button_Click(object sender, EventArgs e)
        {
            UpdateOrdersProducts form = new UpdateOrdersProducts(OrdersProductsLabels, bindingNavigator_OrdersProducts);
            form.Show();
        }

        private void updateProduct_button_Click(object sender, EventArgs e)
        {
            UpdateProduct form = new UpdateProduct(ProductLabels, bindingNavigator_Products);
            form.Show();
        }

        private void addRelationship_button_Click(object sender, EventArgs e)
        {
            NewOrdersProducts form = new NewOrdersProducts(bindingNavigator_OrdersProducts);
            form.Show();
        }

        private void toolStripLabel2_TextChanged(object sender, EventArgs e)
        {
            AppController.syncOrdersProductsTab(AppDAO.getBindSourceOrdersProducts(), OrdersProductsLabels,
                deleteRelationship_button, updateRelationship_button);
        }

        private void bindingNavigatorCountItem5_TextChanged(object sender, EventArgs e)
        {
            AppController.syncProductsTab(AppDAO.getBindSourceProducts(), ProductLabels,
                deleteProduct_button, updateProduct_button);
        }

        private void toolStripLabel1_TextChanged(object sender, EventArgs e)
        {
            AppController.syncOrdersTab(AppDAO.getBindSourceOrders(), OrderLabels,
                deleteOrder_button, updateOrder_button);
        }

        private void bindingNavigatorCountItem4_TextChanged(object sender, EventArgs e)
        {
            AppController.syncCustomersTab(AppDAO.getBindSourceCustomer(), CustomerLabels, pictureBox_customer,
                deleteCustomer_button, updateCustomer_button);
        }

        public static RichTextBox getCommentsRichTextbox()
        {
            return commentsRichTextBoxGlobal;
        }
        

        private void customerIds_combobox_TextChanged(object sender, EventArgs e)
        {
            AppController.createCustomersHistoryDataGrid(ordersHistory_dataGridView, customerIds_combobox, totalColumn, ordersHistoryTotal_label);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }


        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            AppController.exportDataForPrinter(ordersHistory_dataGridView, e);
        }

        
    }


}

