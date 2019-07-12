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
    class ItemController
    {
        static MySqlConnection conn = DBUtils.GetDBConnection();
        public static Boolean addNewItem(ItemDTO itemDTO)
        {
            int result=0;
            try
            {

                String query = "INSERT INTO pos.item (itemcode,itemname,quantity,price) VALUES (@itemcode, @itemname, @quantity,@price)";

                MySqlCommand command = new MySqlCommand(query, conn);

                //Console.WriteLine(custDTO.getNic() + " " + custDTO.getName());

                command.Parameters.AddWithValue("@itemcode", itemDTO.getItemCode());
                command.Parameters.AddWithValue("@itemname", itemDTO.getItemName());
                command.Parameters.AddWithValue("@quantity", itemDTO.getQuantity());
                command.Parameters.AddWithValue("@price", itemDTO.getPrice());

                conn.Open();

                result = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("exception occured");
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

        public static ItemDTO searchItem(String itemCode)
        {
            ItemDTO itemDTO = new ItemDTO();
            try
            {
                String query = "select * from item where itemcode=@itemcode;";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@itemcode", itemCode);
                conn.Open();

                MySqlDataReader dataReader = command.ExecuteReader();
                
                //int count = 0;
                while (dataReader.Read())
                {
                    itemDTO.setItemCode(dataReader["itemcode"].ToString());
                    itemDTO.setItemName(dataReader["itemname"].ToString());
                    itemDTO.setPrice(double.Parse(dataReader["price"].ToString()));
                    itemDTO.setQuantity(int.Parse(dataReader["quantity"].ToString()));
                    //Console.WriteLine(dataReader["itemcode"] + " " + dataReader["itemname"] + " " + dataReader["quantity"] + " " + dataReader["price"]);
                    //count++;
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
            return itemDTO;

        }

        public static Boolean removeItem(String itemcode)
        {
            int result = 0;
            try
            {
                conn.Open();
                string deleteQuery = "DELETE FROM pos.item WHERE itemcode =@itemcode; ";
                MySqlCommand command = new MySqlCommand(deleteQuery, conn);
                command.Parameters.AddWithValue("@itemcode", itemcode);

                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        public static Boolean updateItem(ItemDTO itemDTO)
        {
            int result=0;

            try
            {

                string query = "update pos.item SET itemname=@itemname, price=@price,quantity=@quantity where itemcode=@itemcode";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@itemname", itemDTO.getItemName());
                command.Parameters.AddWithValue("@price", itemDTO.getPrice());
                command.Parameters.AddWithValue("@quantity", itemDTO.getPrice());
                command.Parameters.AddWithValue("@itemcode", itemDTO.getItemCode());
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
            if (result > 0)
                return true;
            else
                return false;
        }

        public static List<ItemDTO> viewItems()
        {
            List<ItemDTO> itemList = new List<ItemDTO>();
            try
            {
                String query = "select * from item";

                MySqlCommand command = new MySqlCommand(query, conn);

                conn.Open();

                MySqlDataReader dataReader = command.ExecuteReader();
                //int result = command.ExecuteNonQuery();
                //using (SqlDataReader reader = command.ExecuteReader())

                while (dataReader.Read())
                {

                    itemList.Add(
                        new ItemDTO(dataReader["itemcode"].ToString(),
                        dataReader["itemname"].ToString(),
                        int.Parse(dataReader["quantity"].ToString()),
                        double.Parse(dataReader["price"].ToString()))
                    );

                }
                


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                conn.Close();
                return itemList;
            }

            Console.Read();
            conn.Close();
            return itemList;
        }
    }
}
