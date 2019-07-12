using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posui
{
    class LoginDTO
    {
        int loginid;
        String username;
        String password;
        String position;

        public LoginDTO() { }

        public LoginDTO(int loginid, String username, String password, String position)
        {
            this.loginid = loginid;
            this.username = username;
            this.password = password;
            this.position = position;
        }

        public int getLoginid()
        {
            return loginid;
        }


        public void setLoginid(int loginid)
        {
            this.loginid = loginid;
        }


        public String getUsername()
        {
            return username;
        }


        public void setUsername(String username)
        {
            this.username = username;
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
