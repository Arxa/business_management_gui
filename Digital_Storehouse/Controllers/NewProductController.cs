using Digital_Storehouse.Daos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Digital_Storehouse.Views;

namespace Digital_Storehouse.Controllers
{
    class NewProductController
    {
        private static DatabaseConnection db = new DatabaseConnection();

        
        public static bool validateFields(Dictionary<String, TextBox> newProductTextboxes)
        {
            if (newProductTextboxes["SELLING_PRICE"].Text.Equals("") || newProductTextboxes["LABEL"].Text.Equals("") 
                || newProductTextboxes["RESERVE"].Text.Equals(""))
            {
                ViewMessages.FillRequiredFields();
                return false;
            }

            int n;
            if (! int.TryParse(newProductTextboxes["RESERVE"].Text, out n))
            {
                ViewMessages.ReserveNotValid();
                return false;
            }

            float k;
            if (!float.TryParse(newProductTextboxes["SELLING_PRICE"].Text, out k))
            {
                ViewMessages.SellingPriceNotValid();
                return false;
            }

            return true;
        }



        public static void addNewProduct(Dictionary<String, TextBox> newProductTextboxes, BindingNavigator productsBindingNavigator, NewProduct newProductForm)
        {
            if (!validateFields(newProductTextboxes)){      
                return;
            }

            try
            {
                int last_page = productsBindingNavigator.BindingSource.Count;

                NewProductDAO.addNewProduct(newProductTextboxes["LABEL"].Text, newProductTextboxes["CATEGORY"].Text, Int32.Parse(newProductTextboxes["RESERVE"].Text),
                                    float.Parse(newProductTextboxes["SELLING_PRICE"].Text), newProductTextboxes["MANUFACTURER"].Text);


                foreach (KeyValuePair<string, Label> entry in App.GetProductLabels())
                {
                    entry.Value.DataBindings.Clear();
                }

                db.BindProductsData(App.GetProductLabels(), productsBindingNavigator);

                productsBindingNavigator.BindingSource.Position = last_page;

                // Added!
                newProductForm.Close();
            }
            catch (SqlException e)
            {
                ViewMessages.ExceptionOccured(e);
            }
        }


    }
}
