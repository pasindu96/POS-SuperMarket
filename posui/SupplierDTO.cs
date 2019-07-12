using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posui
{
    class SupplierDTO
    {
        string supplierid;
        string name;
        string address;
        string mobile;

        public SupplierDTO()
        {

        }
        public SupplierDTO(string supplierid,string name,string address, string mobile)
        {
            this.supplierid = supplierid;
            this.name = name;
            this.mobile = mobile;
            this.address = address;
        }
        public String getSupplierid()
        {
            return supplierid;
        }

        
        public void setSupplierid(String supplierid)
        {
            this.supplierid = supplierid;
        }

        public String getName()
        {
            return name;
        }

        
        public void setName(String name)
        {
            this.name = name;
        }

        public String getAddress()
        {
            return address;
        }

        public void setAddress(String address)
        {
            this.address = address;
        }

        
        public String getMobile()
        {
            return mobile;
        }

        
        public void setMobile(String mobile)
        {
            this.mobile = mobile;
        }
    }
}
