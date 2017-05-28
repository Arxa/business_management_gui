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
    class UpdateOrdersProductsController
    {
        private static DatabaseConnection db = new DatabaseConnection();

        public static void updateOrdersProducts(TextBox amountTextbox, BindingNavigator bindingNavigatorOrdersProducts, 
                                            UpdateOrdersProducts updateOrdersProductsForm, int idOrder, int idProduct)
        {

            float n;
            if (! float.TryParse(amountTextbox.Text, out n))
            {
                ViewMessages.AmountNotValid();
                return;
            }

            try
            {
                int currentPage = bindingNavigatorOrdersProducts.BindingSource.Position;

                UpdateOrdersProductsDAO.updateOrdersProducts(float.Parse(amountTextbox.Text), idOrder, idProduct);

                foreach (KeyValuePair<string, Label> entry in App.GetOrdersProductsLabels())
                {
                    entry.Value.DataBindings.Clear();
                }

                db.BindOrdersProductsData(App.GetOrdersProductsLabels(), bindingNavigatorOrdersProducts);

                bindingNavigatorOrdersProducts.BindingSource.Position = currentPage;

                // Updated!
                updateOrdersProductsForm.Close();
            }
            catch (SqlException e)
            {
                ViewMessages.ExceptionOccured(e);
            }
        }

    }
}
