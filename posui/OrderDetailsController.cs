using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace posui
{
    class OrderDetailsController
    {
        static MySqlConnection conn = DBUtils.GetDBConnection();
        public static void addOrderDetails(OrderDetailsDTO odDTO)
        {

            /* try
             {
                 String query="INSERT INTO pos.orderdetail (orderid,itemcode,quantity) VALUES (@orderid, @itemcode, @quantity)";

                 //MySqlCommand command = new MySqlCommand(query, conn);
                 MySqlCommand command = new MySqlCommand(query,conn);


             }
             catch (Exception ex)
             {

                 throw;
             }*/
        }
    }
}
