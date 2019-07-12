using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace posui
{
    class LoginController
    {
        static MySqlConnection conn = DBUtils.GetDBConnection();

        public static Boolean createUser(UserLoginDTO userLoginDTO)
        {
            int result = 0;
            try
            {

                String query = "INSERT INTO pos.userlogin (username,name,password,position) VALUES (@username, @name, @password,@position)";

                MySqlCommand command = new MySqlCommand(query, conn);

                //Console.WriteLine(custDTO.getNic()+" "+custDTO.getName());

                command.Parameters.AddWithValue("username", userLoginDTO.getUsername());
                command.Parameters.AddWithValue("@name", userLoginDTO.getName());
                command.Parameters.AddWithValue("@password", userLoginDTO.getPassword());
                command.Parameters.AddWithValue("@position", userLoginDTO.getPosition());

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

        /* public static LoginDTO searchUser(int id)
         {
             LoginDTO user = new LoginDTO();
             try
             {
                 String query = "select * from login where id=@id;";
                 MySqlCommand command = new MySqlCommand(query, conn);
                 command.Parameters.AddWithValue("@id", id);
                 conn.Open();

                 MySqlDataReader dataReader = command.ExecuteReader();
                 //int result = command.ExecuteNonQuery();
                 //using (SqlDataReader reader = command.ExecuteReader())
                 //int count = 0;

                 while (dataReader.Read())
                 {
                     user.setPassword(dataReader["password"].ToString());
                     user.setLoginid(Int32.Parse(dataReader["id"].ToString()));
                     user.setPosition(dataReader["position"].ToString());
                     user.setUsername(dataReader["username"].ToString());
                     //Console.WriteLine(dataReader["NIC"] + " " + dataReader["Name"] + " " + dataReader["Address"]);
                     //count++;
                 }


             }
             catch (Exception ex)
             {
                 Console.WriteLine("Error: " + ex.Message);
                 return null;
             }

             Console.Read();
             conn.Close();
             return user;
         }
         */

        public static UserLoginDTO searchUser(string username)
        {
            UserLoginDTO user = new UserLoginDTO();
            try
            {
                String query = "select * from userlogin where username=@username;";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@username", username);
                conn.Open();

                MySqlDataReader dataReader = command.ExecuteReader();
                //int result = command.ExecuteNonQuery();
                //using (SqlDataReader reader = command.ExecuteReader())
                //int count = 0;

                while (dataReader.Read())
                {
                    user.setPassword(dataReader["password"].ToString());
                    user.setName(dataReader["name"].ToString());
                    user.setPosition(dataReader["position"].ToString());
                    user.setUsername(dataReader["username"].ToString());
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
            return user;
        }

        public static Boolean updateUser(UserLoginDTO userLoginDTO)
        {

            try
            {

                string query = "update pos.userlogin SET password=@password,position=@position,name=@name where username=@username";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@password", userLoginDTO.getPassword());
                command.Parameters.AddWithValue("@position", userLoginDTO.getPosition());
                command.Parameters.AddWithValue("@username", userLoginDTO.getUsername());
                command.Parameters.AddWithValue("@name", userLoginDTO.getName());

                conn.Open();

                if (command.ExecuteNonQuery() != 1)
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                conn.Close();
                return false;
            }

            Console.Read();
            conn.Close();
            return true;
        }
        public static List<UserLoginDTO> viewCurrentUsers()
        {
            List<UserLoginDTO> currentUserList = new List<UserLoginDTO>();
            try
            {
                string query = "select username,name,password,position from userlogin;";
                MySqlCommand command = new MySqlCommand(query,conn);
                conn.Open();
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    currentUserList.Add(
                        new UserLoginDTO(
                            dataReader["username"].ToString(),
                            dataReader["name"].ToString(),
                            dataReader["password"].ToString(),
                            dataReader["position"].ToString())
                        );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : "+ex.ToString());
                conn.Close();
                return null;
            }
            Console.Read();
            conn.Close();
            return currentUserList;
        }
    }
}
