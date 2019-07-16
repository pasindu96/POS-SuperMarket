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
        public static Boolean addOrderDetails(OrderDetailsDTO odDTO)
        {
            
            int result;
            try
             {
                 String query= "INSERT INTO pos.orderdetail (orderid,itemcode,quantity) VALUES (@orderid, @itemcode, @quantity)";

                MySqlCommand command = new MySqlCommand(query,conn);
                command.Parameters.AddWithValue("@orderid", odDTO.getOrderID());
                command.Parameters.AddWithValue("@itemcode", odDTO.getItemCode());
                command.Parameters.AddWithValue("@quantity", odDTO.getQuantity());

                conn.Open();
                result = command.ExecuteNonQuery();
             }
             catch (Exception ex)
             {
                Console.WriteLine("Error : "+ex.ToString());
                MessageBox.Show("Error : " + ex.ToString());
                conn.Close();
                return false;
             }
            conn.Close();
            Console.ReadLine();
            if (result == 1)
                return true;
            else
                return false;   
        }
    }
}
