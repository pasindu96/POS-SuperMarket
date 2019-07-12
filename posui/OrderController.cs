using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace posui
{
    class OrderController
    {
        static MySqlConnection conn = DBUtils.GetDBConnection();
        public static void addNewOrder(OrderDTO orderDTO)
        {
            try
            {

                String query = "INSERT INTO pos.orders (orderid,custid,amount,date) VALUES (@orderid, @custid, @amount,CURRENT_TIMESTAMP)";

                MySqlCommand command = new MySqlCommand(query, conn);

                //Console.WriteLine(custDTO.getNic() + " " + custDTO.getName());

                command.Parameters.AddWithValue("@orderid", orderDTO.getOrderID());
                command.Parameters.AddWithValue("@custid", orderDTO.getCustID());
                command.Parameters.AddWithValue("@amount", orderDTO.getAmount());

                conn.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("DATA UPDATED");
                }
                else
                {
                    MessageBox.Show("Data NOT UPDATED");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.Read();
            conn.Close();
        }

        public static void searchOrder(String orderID)
        {
            try
            {
                String query = "select * from orders where orderid=@orderid;";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@orderid", orderID);
                conn.Open();

                MySqlDataReader dataReader = command.ExecuteReader();
                //int result = command.ExecuteNonQuery();
                //using (SqlDataReader reader = command.ExecuteReader())
                int count = 0;
                while (dataReader.Read())
                {
                    Console.WriteLine(dataReader["orderid"] + " " + dataReader["custid"] + " " + dataReader["amount"] + " " + dataReader["date"]);
                    count++;
                }
                if (count == 0)
                    MessageBox.Show("No relevant data..");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.Read();
            conn.Close();

        }

        public static void removeOrder(String orderid)
        {
            try
            {
                conn.Open();
                string deleteQuery = "DELETE FROM pos.orders WHERE orderid =@orderid; ";
                MySqlCommand command = new MySqlCommand(deleteQuery, conn);
                command.Parameters.AddWithValue("@orderid", orderid);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Order DELETED");
                }
                else
                {
                    MessageBox.Show("Order is not removed due to an error");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public static void updateOrder(OrderDTO orderDTO)
        {

            try
            {

                string query = "update pos.orders SET custid=@custid,amount=@amount where orderid=@orderid";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@custid", orderDTO.getCustID());
                command.Parameters.AddWithValue("@amount", orderDTO.getAmount());
                command.Parameters.AddWithValue("@orderid", orderDTO.getOrderID());
                conn.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Order data UPDATED");
                }
                else
                {
                    MessageBox.Show("Data NOT UPDATED");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.Read();
            conn.Close();
        }
    }
}
