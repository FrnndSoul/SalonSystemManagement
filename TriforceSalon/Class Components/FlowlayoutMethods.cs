using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TriforceSalon.Class_Components
{
    public class FlowlayoutMethods
    {
        public readonly string mysqlcon;

        public FlowlayoutMethods()
        {
            mysqlcon = "server=localhost;user=root;database=salondatabase;password=";
        }

            
    }
}
