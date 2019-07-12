using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace posui
{
    class CustomerController
    {
        static MySqlConnection conn = DBUtils.GetDBConnection();

        public static Boolean createNewUser(CustomerDTO custDTO)
        {
            int result = 0;
            try
            {

                String query = "INSERT INTO pos.customer (NIC,Name,Address,Telephone) VALUES (@NIC, @Name, @Address,@Telephone)";

                MySqlCommand command = new MySqlCommand(query, conn);

                //Console.WriteLine(custDTO.getNic()+" "+custDTO.getName());

                command.Parameters.AddWithValue("@NIC", custDTO.getNic());
                command.Parameters.AddWithValue("@Name", custDTO.getName());
                command.Parameters.AddWithValue("@Address", custDTO.getAddress());
                command.Parameters.AddWithValue("@Telephone", custDTO.getMobile());

                conn.Open();
                result = command.ExecuteNonQuery();
                /*if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("DATA UPDATED");
                }
                else
                {
                    MessageBox.Show("Data NOT UPDATED");
                }*/

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
        public static CustomerDTO searchUser(String Telephone)
        {
            CustomerDTO customer = new CustomerDTO();
            try
            {
                String query = "select * from customer where Telephone=@Telephone;";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@Telephone", Telephone);
                conn.Open();

                MySqlDataReader dataReader = command.ExecuteReader();
                //int result = command.ExecuteNonQuery();
                //using (SqlDataReader reader = command.ExecuteReader())
                //int count = 0;

                while (dataReader.Read())
                {
                    customer.setNic(dataReader["NIC"].ToString());
                    customer.setName(dataReader["Name"].ToString());
                    customer.setAddress(dataReader["Address"].ToString());
                    customer.setMobile(dataReader["Telephone"].ToString());
                    //Console.WriteLine(dataReader["NIC"] + " " + dataReader["Name"] + " " + dataReader["Address"]);
                    //count++;
                }
                /*if(count==0)
                    MessageBox.Show("No relevant data..");*/

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                conn.Close();
                return null;
            }

            Console.Read();
            conn.Close();
            return customer;
        }
        public static Boolean removeUser(String telephone)
        {
            int result = 0;
            try
            {
                
                conn.Open();
                string deleteQuery = "DELETE FROM pos.customer WHERE Telephone =@Telephone; ";
                MySqlCommand command = new MySqlCommand(deleteQuery, conn);
                command.Parameters.AddWithValue("@Telephone", telephone);

                result = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return false;
            }
            conn.Close();
            if (result == 0)
                return false;
            else
                return true;
            
        }
        public static Boolean updateUser(CustomerDTO custDTO)
        {
            int result;
            try
            {

                string query = "update pos.customer SET Name=@Name, Address=@Address,Telephone=@Telephone where NIC=@NIC";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@Name", custDTO.getName());
                command.Parameters.AddWithValue("@Address", custDTO.getAddress());
                command.Parameters.AddWithValue("@Telephone", custDTO.getMobile());
                command.Parameters.AddWithValue("@NIC", custDTO.getNic());
                conn.Open();

                result=command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                conn.Close();
                return false;
            }

            Console.Read();
            conn.Close();
            if (result > 0)
                return true;
            else
                return false;
        }
        //----------------------------------------------------------------------------------------
        public static List<CustomerDTO> viewUsers()
        {
            List<CustomerDTO> custList = new List<CustomerDTO>();
            try
            {
                String query = "select * from customer";

                MySqlCommand command = new MySqlCommand(query, conn);

                conn.Open();

                MySqlDataReader dataReader = command.ExecuteReader();
                //int result = command.ExecuteNonQuery();
                //using (SqlDataReader reader = command.ExecuteReader())
                //int count = 0;
                while (dataReader.Read())
                {

                    custList.Add(
                        new CustomerDTO(dataReader["NIC"].ToString(),
                        dataReader["Name"].ToString(),
                        dataReader["Address"].ToString(),
                        dataReader["Telephone"].ToString())
                    );

                    //Console.WriteLine(dataReader["NIC"] + " " + dataReader["Name"] + " " + dataReader["Address"]);
                    //count++;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                conn.Close();
                return custList;
            }

            Console.Read();
            conn.Close();
            return custList;
        }
    }
}
