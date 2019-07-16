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
            cmbItemDescription.SelectedIndex=0;
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
            try
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
                        clearFields();
                    }
                    else
                    {
                        clearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : "+ex.ToString());
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
                cmbItemDescription.Items.Add(item.getItemName());
            }
        }
        private void loadItemDescription()
        {
            List<ItemDTO> itemList = new List<ItemDTO>();
            itemList = ItemController.viewItems();
            foreach (ItemDTO item in itemList)
            {
                cmbItemDescription.Items.Add(item.getItemName());
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
            /*ItemDTO item = new ItemDTO();
            item = ItemController.searchItem((cmbItemCode.SelectedItem).ToString());
            txtItemDescription.Text = item.getItemName();
            txtQtyOnHand.Text = (item.getQuantity()).ToString();
            txtUnitPrice.Text = (item.getPrice()).ToString();
            codeOfItem = item.getItemCode();*/
            ItemDTO item = new ItemDTO();
            item = ItemController.searchItemDescription((cmbItemDescription.SelectedItem).ToString());
            txtItemCode.Text = item.getItemCode();
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
            String[] row = new String[] {(cmbItemDescription.SelectedItem).ToString(), txtItemCode.Text, txtUnitPrice.Text, txtQty.Text,(double.Parse(txtUnitPrice.Text)*(int.Parse(txtQty.Text))).ToString() };
            tblCheckOut.Rows.Add(row);
            txtTotalAmount.Text = finalTot.ToString();
            ItemController.updateStockQty(new ItemDTO(codeOfItem, "", (int.Parse(txtQtyOnHand.Text) - int.Parse(txtQty.Text)), 0.0));
            txtQtyOnHand.Text = (int.Parse(txtQtyOnHand.Text) - int.Parse(txtQty.Text)).ToString();
        }

        private void TxtCustomerMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                CustomerDTO customer = new CustomerDTO();
                customer = CustomerController.searchUser(txtCustomerMobile.Text);
                txtCustomerName.Text = customer.getName();
                cmbItemDescription.Focus();
            }
        }

        private void TxtQty_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                if (Validation.validateTextFields(txtQty.Text)|| e.KeyChar != (char)13)
                {
                    finalTot += (double.Parse(txtUnitPrice.Text) * (int.Parse(txtQty.Text)));
                    orderDetails.Add(new OrderDetailsDTO(txtOrderID.Text, codeOfItem, int.Parse(txtQty.Text)));
                    String[] row = new String[] { txtItemCode.Text, (cmbItemDescription.SelectedItem).ToString(),  txtUnitPrice.Text, txtQty.Text, (double.Parse(txtUnitPrice.Text) * (int.Parse(txtQty.Text))).ToString() };
                    tblCheckOut.Rows.Add(row);
                    txtTotalAmount.Text = finalTot.ToString();
                    ItemController.updateStockQty(new ItemDTO(codeOfItem, "", (int.Parse(txtQtyOnHand.Text) - int.Parse(txtQty.Text)), 0.0));
                    txtQtyOnHand.Text = (int.Parse(txtQtyOnHand.Text) - int.Parse(txtQty.Text)).ToString();
                }
                else
                {
                    MessageBox.Show("Please enter the quantity");
                }
                
            }    
        }
        private void TxtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cash = "";
            cash += (txtCash.Text);
            

            if (e.KeyChar == (char)13)
            {
                txtCash.Text = cash;
                txtBalance.Text = ((double.Parse(txtCash.Text)) - (double.Parse(txtTotalAmount.Text))).ToString();
            }
        }
        private void clearFields()
        {
            txtCustomerMobile.Text = "";
            txtCustomerName.Text = "";
            txtQty.Text = "";
            txtTotalAmount.Text = "";
            txtCash.Text = "";
            txtBalance.Text = "";
            loadOrderID();
            //Clear the table rows before process to the next order
            tblCheckOut.DataSource =null;
            tblCheckOut.Rows.Clear();
        }

        private void BtnRemoveItems_Click(object sender, EventArgs e)
        {
            if (tblCheckOut.SelectedCells.Count > 0)
            {
                int row = tblCheckOut.CurrentCell.RowIndex;
                String curValue = tblCheckOut.CurrentCell.Value.ToString();
                DataGridViewRow selectedRow = tblCheckOut.Rows[row];
                string code = selectedRow.Cells[0].Value.ToString();
                txtTotalAmount.Text = (double.Parse(txtTotalAmount.Text) - double.Parse(selectedRow.Cells[4].Value.ToString())).ToString();
                ItemDTO current = ItemController.searchItem(code);
                ItemController.updateStockQty(new ItemDTO(code, "", int.Parse(selectedRow.Cells[3].Value.ToString()) + current.getQuantity(), 0.0));
                int qty = int.Parse(selectedRow.Cells[3].Value.ToString());
                txtQtyOnHand.Text = (current.getQuantity() + qty).ToString();
                tblCheckOut.Rows.RemoveAt(row);
            }
            else
            {
                MessageBox.Show("Please select a column");
            }
            
        }
    }
}
