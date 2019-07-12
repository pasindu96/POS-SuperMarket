using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace posui
{
    public partial class checkout : Form
    {
        public checkout()
        {
            InitializeComponent();
            loadOrderID();
            loadItems();
            cmbItemCode.SelectedIndex=0;
            SetDate();
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCheckoutPrint_Click(object sender, EventArgs e)
        {
            OrderDTO order = new OrderDTO();
            order.setOrderID(int.Parse(txtOrderID.Text));
            order.setCustMobile(txtCustomerMobile.Text);
            order.setDate(txtOrderDate.Text);
            order.setAmount(double.Parse(txtTotalAmount.Text));
            Boolean orderStatus = OrderController.addNewOrder(order);
            DialogResult result;
            if (orderStatus)
            {
                foreach (OrderDetailsDTO odDTO in orderDetails)
                {
                    OrderDetailsController.addOrderDetails(odDTO);
                }

                result = MessageBox.Show("Do you want to print the bill?", "Information", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Do something here
                }
                    
            }

        }
        private void loadOrderID()
        {
            int orderID = OrderController.countOrders();
            txtOrderID.Text =(orderID+1).ToString();
        }
        private void loadItems()
        {
            List<ItemDTO> itemList = new List<ItemDTO>();
            itemList = ItemController.viewItems();
            foreach (ItemDTO item in itemList)
            {
                cmbItemCode.Items.Add(item.getItemCode());
            }
        }
        private void SetDate()
        {
            DateTime date = DateTime.Now;
            txtOrderDate.Text = (date.ToString("yyyy-MM-dd"));
        }
        private string codeOfItem="";

        private void CmbItemCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemDTO item = new ItemDTO();
            item = ItemController.searchItem((cmbItemCode.SelectedItem).ToString());
            txtItemDescription.Text = item.getItemName();
            txtQtyOnHand.Text = (item.getQuantity()).ToString();
            txtUnitPrice.Text = (item.getPrice()).ToString();
            codeOfItem = item.getItemCode();
        }

        private void TxtCustomerMobile_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TxtCustomerMobile_Enter(object sender, EventArgs e)
        {
            
        }

        private void TxtCustomerMobile_Click(object sender, EventArgs e)
        {
            
        }
        

        private void Button1_Click(object sender, EventArgs e)
        {
            CustomerDTO customer = new CustomerDTO();
            customer = CustomerController.searchUser(txtCustomerMobile.Text);
            txtCustomerName.Text = customer.getName();
        }
        List<OrderDetailsDTO> orderDetails = new List<OrderDetailsDTO>();
        Double finalTot = 0;
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            finalTot += (double.Parse(txtUnitPrice.Text) * (int.Parse(txtQty.Text)));
            orderDetails.Add(new OrderDetailsDTO(txtOrderID.Text,codeOfItem,int.Parse(txtQty.Text)));
            String[] row = new String[] {(cmbItemCode.SelectedItem).ToString(), txtItemDescription.Text, txtUnitPrice.Text, txtQty.Text,(double.Parse(txtUnitPrice.Text)*(int.Parse(txtQty.Text))).ToString() };
            tblCheckOut.Rows.Add(row);
            txtTotalAmount.Text = finalTot.ToString();
            ItemController.updateStockQty(new ItemDTO(codeOfItem, "", (int.Parse(txtQtyOnHand.Text) - int.Parse(txtQty.Text)), 0.0));
            txtQtyOnHand.Text = (int.Parse(txtQtyOnHand.Text) - int.Parse(txtQty.Text)).ToString();
        }
    }
}
