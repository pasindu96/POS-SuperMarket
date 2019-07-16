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
        public static Boolean addNewOrder(OrderDTO orderDTO)
        {
            int result=0;
            try
            {

                String query = "INSERT INTO pos.orders (orderid,custmobile,amount,date) VALUES (@orderid, @custmobile, @amount,@date)";

                MySqlCommand command = new MySqlCommand(query, conn);

                command.Parameters.AddWithValue("@orderid", orderDTO.getOrderID());
                command.Parameters.AddWithValue("@custmobile",orderDTO.getCustMobile());
                command.Parameters.AddWithValue("@amount", orderDTO.getAmount());
                command.Parameters.AddWithValue("@date", orderDTO.getDate());


                conn.Open();
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                conn.Close();
                return false;

            }

            Console.Read();
            conn.Close();
            if (result == 1)
                return true;
            else
                return false;
        }

        public static List<OrderDTO> searchOrder(String date)
        {
            List<OrderDTO> orderList = new List<OrderDTO>();
            //orderList = null;
            try
            {
                String query = "select * from orders where date=@date;";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@date", date);
                conn.Open();
                
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    orderList.Add(new OrderDTO(
                             int.Parse(dataReader["orderid"].ToString()),
                             dataReader["custmobile"].ToString(),
                             double.Parse(dataReader["amount"].ToString()),
                             dataReader["date"].ToString()
                     ));
                }
                

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                conn.Close();
                return null;
            }

            Console.Read();
            conn.Close();
            return orderList;
        }

        public static List<OrderDTO> searchPeriodicOrder(String startDate,string endDate)
        {
            List<OrderDTO> orderList = new List<OrderDTO>();
            //orderList = null;
            try
            {
                String query = "SELECT * FROM orders WHERE date BETWEEN @startDate AND @endDate;";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);
                conn.Open();

                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    orderList.Add(new OrderDTO(
                             int.Parse(dataReader["orderid"].ToString()),
                             dataReader["custmobile"].ToString(),
                             double.Parse(dataReader["amount"].ToString()),
                             dataReader["date"].ToString()
                     ));
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                conn.Close();
                return null;
            }

            Console.Read();
            conn.Close();
            return orderList;
        }


        //----------------------------------------------------------------------------------------
        public static int countOrders()
        {
            int result = 0;
            try
            {
                String query = "select COUNT(orderid) from orders";
               
                MySqlCommand command = new MySqlCommand(query, conn);  
                conn.Open();

                result = int.Parse(command.ExecuteScalar().ToString());

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                conn.Close();
                return result;
            }

            Console.Read();
            conn.Close();
            return result;

        }

        //-----------------------------------------------------------------------------------------

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
                conn.Close();
            }
            conn.Close();
        }

        public static void updateOrder(OrderDTO orderDTO)
        {

            try
            {

                string query = "update pos.orders SET custmobile=@custmobile,amount=@amount where orderid=@orderid";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@custid", orderDTO.getCustMobile());
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
                conn.Close();
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.Read();
            conn.Close();
        }
    }
}
