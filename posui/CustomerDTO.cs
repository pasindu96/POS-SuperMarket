using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posui
{
    class CustomerDTO
    {
        private String name;
        private String nic;
        private String mobile;
        private String address;

        public CustomerDTO() { }

        public CustomerDTO(String nic, String name, String mobile, String address)
        {
            this.nic = nic;
            this.name = name;
            this.mobile = mobile;
            this.address = address;
        }

        //public CustomerDTO() { }
        public String getName()
        {
            return name;
        }


        public void setName(String name)
        {
            this.name = name;
        }


        public String getNic()
        {
            return nic;
        }

        public void setNic(String nic)
        {
            this.nic = nic;
        }


        public String getMobile()
        {
            return mobile;
        }

        public void setMobile(String mobile)
        {
            this.mobile = mobile;
        }


        public String getAddress()
        {
            return address;
        }

        public void setAddress(String address)
        {
            this.address = address;
        }
    }
}
