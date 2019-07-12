using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posui
{
    class ItemDTO
    {
        private String itemCode;
        private String itemName;
        private int quantity;
        private Double price;

        public ItemDTO() { }

        public ItemDTO(String itemCode, String itemName, int quantity, Double price)
        {
            this.itemCode = itemCode;
            this.itemName = itemName;
            this.quantity = quantity;
            this.price = price;
        }


        public String getItemCode()
        {
            return itemCode;
        }


        public void setItemCode(String itemCode)
        {
            this.itemCode = itemCode;
        }


        public String getItemName()
        {
            return itemName;
        }


        public void setItemName(String itemName)
        {
            this.itemName = itemName;
        }


        public int getQuantity()
        {
            return quantity;
        }


        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }


        public Double getPrice()
        {
            return price;
        }


        public void setPrice(Double price)
        {
            this.price = price;
        }
    }
}
