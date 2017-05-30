using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Storehouse.Models
{
    public static class Container
    {
        public static readonly string EMPTY = "";
        public static readonly int HAS_PHOTO_TRUE = 1;
        public static readonly int HAS_PHOTO_FALSE = 0;
        public static readonly string CONNECTION_STRING = "Data Source=ARXA-PC;Initial Catalog=Storehouse;Integrated Security=True";
        public static readonly string SELECT_FAILURE = "-1";
        public static readonly string TOTAL_COLUMN_NAME = "Total (€)";
        public static readonly string PRINT_ICON_TOOLTIP = "Export Data For Printer";
    }
}
