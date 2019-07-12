using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posui
{
    class OrderDetailsDTO
    {
        private string orderid;
        private string itemcode;
        private int quantity;

        public OrderDetailsDTO() { }
        public OrderDetailsDTO(string orderid, string itemcode, int quantity)
        {
            this.orderid = orderid;
            this.itemcode = itemcode;
            this.quantity = quantity;
        }
        public void setOrderID(String orderid)
        {
            this.orderid = orderid;
        }
        public string getOrderID()
        {
            return orderid;
        }

        public string getItemCode()
        {
            return itemcode;
        }
        public void setquantity(int quantity)
        {
            this.quantity = quantity;
        }
        public int getQuantity()
        {
            return quantity;
        }
    }
}
