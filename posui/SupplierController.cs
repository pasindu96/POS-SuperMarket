using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace posui
{
    class SupplierController
    {
        static MySqlConnection connection = DBUtils.GetDBConnection();
        public static Boolean addSupplier(SupplierDTO supplierDTO)
        {
            int result=0;
            try
            {
                string query = "insert into supplier (supplierid,name,address,mobile) values (@supplierid,@name,@address,@mobile)";
                MySqlCommand command = new MySqlCommand(query,connection);
                command.Parameters.AddWithValue("@supplierid",supplierDTO.getSupplierid());
                command.Parameters.AddWithValue("@name", supplierDTO.getName());
                command.Parameters.AddWithValue("@address", supplierDTO.getAddress());
                command.Parameters.AddWithValue("@mobile", supplierDTO.getMobile());

                connection.Open();
                result = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : "+ex.ToString());
                connection.Close();
               // MessageBox.Show("Error : " + ex.ToString());
                return false;
            }

            Console.Read();
            connection.Close();

            if (result == 1)
                return true;
            else
                return false;
        }
        public static SupplierDTO searchSupplier(String supplierid)
        {
            SupplierDTO supDTO = new SupplierDTO();

            try
            {
                String query = "select * from supplier where supplierid=@supplierid;";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@supplierid", supplierid);
                connection.Open();

                MySqlDataReader dataReader = command.ExecuteReader();
                //int result = command.ExecuteNonQuery();
                //using (SqlDataReader reader = command.ExecuteReader())
                //int count = 0;

                while (dataReader.Read())
                {
                    supDTO.setSupplierid(dataReader["supplierid"].ToString());
                    supDTO.setName(dataReader["name"].ToString());
                    supDTO.setAddress(dataReader["address"].ToString());
                    supDTO.setMobile(dataReader["mobile"].ToString());
                    //Console.WriteLine(dataReader["NIC"] + " " + dataReader["Name"] + " " + dataReader["Address"]);
                    //count++;
                }
                /*if(count==0)
                    MessageBox.Show("No relevant data..");*/

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                connection.Close();
                //MessageBox.Show("Error : " + ex.ToString());
                return null;
            }

            Console.Read();
            connection.Close();
            return supDTO;
        }
        public static Boolean removeSupplier(String supplierid)
        {
            int result = 0;
            try
            {

                connection.Open();
                string deleteQuery = "DELETE FROM  supplier WHERE supplierid =@supplierid; ";
                MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@supplierid", supplierid);

                result = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : "+ex.ToString());
                connection.Close();
                //MessageBox.Show("Error : " + ex.ToString());
                return false;
            }
            connection.Close();
            if (result == 0)
                return false;
            else
                return true;

        }
        public static Boolean updateSupplier(SupplierDTO supDTO)
        {
            int result;
            try
            {

                string query = "update supplier SET name=@name, address=@address,mobile=@mobile where supplierid=@supplierid";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", supDTO.getName());
                command.Parameters.AddWithValue("@address", supDTO.getAddress());
                command.Parameters.AddWithValue("@mobile", supDTO.getMobile());
                command.Parameters.AddWithValue("@supplierid", supDTO.getSupplierid());

                connection.Open();

                result = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                connection.Close();
                //MessageBox.Show("Error : " + ex.ToString());
                return false;
            }

            Console.Read();
            connection.Close();
            if (result > 0)
                return true;
            else
                return false;
        }
        
        public static List<SupplierDTO> viewUsers()
        {
            List<SupplierDTO> supList = new List<SupplierDTO>();
            try
            {
                String query = "select * from supplier";

                MySqlCommand command = new MySqlCommand(query, connection);

                connection.Open();

                MySqlDataReader dataReader = command.ExecuteReader();
                //int result = command.ExecuteNonQuery();
                //using (SqlDataReader reader = command.ExecuteReader())
                //int count = 0;
                while (dataReader.Read())
                {

                    supList.Add(
                        new SupplierDTO(
                            dataReader["supplierid"].ToString(),
                            dataReader["name"].ToString(),
                            dataReader["address"].ToString(),
                            dataReader["mobile"].ToString()

                        )
                );

                    //Console.WriteLine(dataReader["NIC"] + " " + dataReader["Name"] + " " + dataReader["Address"]);
                    //count++;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                connection.Close();
                //MessageBox.Show("Error : " + ex.ToString());
                return null;
            }

            Console.Read();
            connection.Close();
            return supList;
        }
    }
}
