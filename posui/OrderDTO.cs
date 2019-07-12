using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posui
{
    class OrderDTO
    {
        private String orderID;
        private String custID;
        private double amount;
        private DateTime date;
        public OrderDTO() { }
        public OrderDTO(string orderID, string custID, Double amount)
        {
            this.orderID = orderID;
            this.custID = custID;
            this.amount = amount;

        }
        public OrderDTO(string orderID, string custID, Double amount, DateTime date)
        {
            this.orderID = orderID;
            this.custID = custID;
            this.amount = amount;
            this.date = date;
        }

        public DateTime getDate()
        {
            return date;
        }


        public void setDate(DateTime date)
        {
            this.date = date;
        }

        public String getOrderID()
        {
            return orderID;
        }


        public void setOrderID(String orderID)
        {
            this.orderID = orderID;
        }


        public String getCustID()
        {
            return custID;
        }


        public void setCustID(String custID)
        {
            this.custID = custID;
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
