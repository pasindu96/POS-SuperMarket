using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posui
{
    class UserLoginDTO
    {

        String username;
        string name;
        String password;
        String position;

        public UserLoginDTO() { }

        public UserLoginDTO(String username, string name, String password, String position)
        {
            this.username = username;
            this.name = name;
            this.password = password;
            this.position = position;
        }

        public string getUsername()
        {
            return username;
        }


        public void setUsername(string username)
        {
            this.username = username;
        }


        public String getName()
        {
            return name;
        }


        public void setName(String name)
        {
            this.name = name;
        }


        public String getPassword()
        {
            return password;
        }


        public void setPassword(String password)
        {
            this.password = password;
        }


        public String getPosition()
        {
            return position;
        }


        public void setPosition(String position)
        {
            this.position = position;
        }
    }
}
