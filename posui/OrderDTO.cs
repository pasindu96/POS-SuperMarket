using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posui
{
    class OrderDTO
    {
        private int orderID;
        private String mobile;
        private double amount;
        private string date;
        public OrderDTO() { }
        public OrderDTO(int orderID, string mobile, Double amount)
        {
            this.orderID = orderID;
            this.mobile = mobile;
            this.amount = amount;

        }
        public OrderDTO(int orderID, string custID, Double amount, string date)
        {
            this.orderID = orderID;
            this.mobile = custID;
            this.amount = amount;
            this.date = date;
        }

        public string getDate()
        {
            return date;
        }


        public void setDate(string date)
        {
            this.date = date;
        }

        public int getOrderID()
        {
            return orderID;
        }


        public void setOrderID(int orderID)
        {
            this.orderID = orderID;
        }


        public String getCustMobile()
        {
            return mobile;
        }


        public void setCustMobile(String mobile)
        {
            this.mobile = mobile;
        }

        public double getAmount()
        {
            return amount;
        }


        public void setAmount(double amount)
        {
            this.amount = amount;
        }
    }
}
