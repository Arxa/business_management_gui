using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Storehouse
{
    public partial class Form1 : Form
    {
        private static Dictionary<String, Label> customerValueLabels = new Dictionary<string, Label>();
        private static Dictionary<String, Label> productValueLabels = new Dictionary<string, Label>();
        private static Dictionary<String, Label> orderValueLabels = new Dictionary<string, Label>();
        private static Dictionary<String, Label> orderProductsValueLabels = new Dictionary<string, Label>();

        public Form1()
        {
            InitializeComponent();

            customerValueLabels["CUSTOMER_ID"] = customerId_value_label;
            customerValueLabels["LAST_NAME"] = lastName_value_label;
            customerValueLabels["FIRST_NAME"] = firstName_value_label;
            customerValueLabels["BIRTH_DATE"] = birthDate_value_label;
            customerValueLabels["AGE"] = age_value_label;
            customerValueLabels["AFM"] = afm_value_label;
            customerValueLabels["DOY"] = doy_value_label;
            customerValueLabels["ADDRESS"] = address_value_label;
            customerValueLabels["CITY"] = city_value_label;
            customerValueLabels["PHONE_NUMBER"] = phoneNumber_value_label;
            customerValueLabels["PHOTO"] = photo_value_label;
            customerValueLabels["COMMENTS"] = comments_value_label;

            productValueLabels["PRODUCT_ID"] = productId_value_label;
            productValueLabels["CATEGORY"] = category_value_label;
            productValueLabels["SELLING_PRICE"] = sellingPrice_value_label;
            productValueLabels["LABEL"] = label_value_label;
            productValueLabels["RESERVE"] = reserve_value_label;
            productValueLabels["MANUFACTURER"] = manufacturer_value_label;

            orderValueLabels["ORDER_ID"] = orderId_value_label;
            orderValueLabels["ORDER_DATE"] = orderDate_value_label;
            orderValueLabels["CUSTOMER_ID_F"] = customerId_F_value_label;
            orderValueLabels["PAYMENT_METHOD"] = paymentMethod_value_label;
            orderValueLabels["DELIVERY_LOCATION"] = deliveryLocation_value_label;

            orderProductsValueLabels["ID_ORDER"] = idOrder_value_label;
            orderProductsValueLabels["ID_PRODUCT"] = idProduct_value_label;
            orderProductsValueLabels["AMOUNT"] = amount_value_label;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controllers.DatabaseController.BindCustomerData(customerValueLabels, bindingNavigator_Customer);
            Controllers.DatabaseController.BindOrderData(orderValueLabels, bindingNavigator_Order);
            Controllers.DatabaseController.BindProductsData(productValueLabels, bindingNavigator_Product);
            Controllers.DatabaseController.BindOrdersProductsData(orderProductsValueLabels, bindingNavigator_OrderProducts);
        }
 
    }
}
