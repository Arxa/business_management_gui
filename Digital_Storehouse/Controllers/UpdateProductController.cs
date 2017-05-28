using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Digital_Storehouse.Daos;
using Digital_Storehouse.Views;

namespace Digital_Storehouse.Controllers
{
    class UpdateProductController
    {
        private static DatabaseConnection db = new DatabaseConnection();

        public static bool validateFields(Dictionary<String, TextBox> productValueLabels)
        {
            if (productValueLabels["SELLING_PRICE"].Text.Equals("") || productValueLabels["LABEL"].Text.Equals("")
                     || productValueLabels["RESERVE"].Text.Equals(""))
            {
                ViewMessages.FillRequiredFields();
                return false;
            }

            int n;
            if (!int.TryParse(productValueLabels["RESERVE"].Text, out n))
            {
                ViewMessages.ReserveNotValid();
                return false;
            }

            float k;
            if (!float.TryParse(productValueLabels["SELLING_PRICE"].Text, out k))
            {
                ViewMessages.SellingPriceNotValid();
                return false;
            }

            return true;
        }



        public static void updateProduct(Dictionary<String, TextBox> productValueLabels, BindingNavigator bindingNavigatorProducts, 
                                    UpdateProduct updateProductForm, int productId)
        {
            if (!validateFields(productValueLabels)){ 
                return;
            }

            try
            {
                int currentPage = bindingNavigatorProducts.BindingSource.Position;

                UpdateProductDAO.updateProduct(productValueLabels["LABEL"].Text, productValueLabels["CATEGORY"].Text, int.Parse(productValueLabels["RESERVE"].Text),
                                            float.Parse(productValueLabels["SELLING_PRICE"].Text), productValueLabels["MANUFACTURER"].Text, productId);


                foreach (KeyValuePair<string, Label> entry in App.GetProductLabels())
                {
                    entry.Value.DataBindings.Clear();
                }

                db.BindProductsData(App.GetProductLabels(), bindingNavigatorProducts);

                bindingNavigatorProducts.BindingSource.Position = currentPage;

                // Updated!
                updateProductForm.Close();
            }
            catch (SqlException e)
            {
                ViewMessages.ExceptionOccured(e);
            }
        }


    }
}
