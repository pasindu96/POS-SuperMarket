using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace posui
{
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
            loadTable();
            txtItemCode.Focus();
            loadItemCode();
        }

        private void loadItemCode()
        {
            int current=ItemController.countItems();
            txtItemCode.Text = (current+1001).ToString();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ItemDTO itemDTO = new ItemDTO(
                    txtItemCode.Text,
                    txtName.Text,
                    int.Parse(txtQty.Text),
                    double.Parse(txtPrice.Text)
                );
                Boolean result = ItemController.addNewItem(itemDTO);
                if (result)
                {
                    MessageBox.Show("Item added Successful");
                    
                    loadItemCode();
                }
                else
                {
                    MessageBox.Show("Error occured.. Item not added to the database");
                }
                clear();
                loadTable();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error : " + ex.ToString());
                clear();
                MessageBox.Show("Enter only accepted types only");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ItemDTO itemDTO = new ItemDTO(
                    txtItemCode.Text,
                    txtName.Text,
                    int.Parse(txtQty.Text),
                    double.Parse(txtPrice.Text)
                );
                Boolean result = ItemController.updateItem(itemDTO);
                if (result)
                {
                    MessageBox.Show("Item updated Successful");
                }
                else
                {
                    MessageBox.Show("Error occured.. Item not updated in the database");
                }
                clear();
                loadTable();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error : "+ex.ToString());
                clear();
                MessageBox.Show("Enter only accepted types only");
            }
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Boolean result = ItemController.removeItem(txtItemCode.Text);
            if (result)
            {
                MessageBox.Show("Item deleted Successful");
            }
            else
            {
                MessageBox.Show("Error occured.. Item not deleted in the database");
            }
            clear();
            loadTable();
        }
        void loadTable()
        {
            List<ItemDTO> itemList = new List<ItemDTO>();
            itemList = ItemController.viewItems();
            tblItem.RowCount = 0;
            foreach (ItemDTO cust in itemList)
            {
                String[] row = new String[] { cust.getItemCode(), cust.getItemName(), cust.getPrice().ToString(), cust.getQuantity().ToString() };
                tblItem.Rows.Add(row);
            }

        }
        void clear()
        {
            loadItemCode();
            txtName.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
            txtItemCode.Focus();

        }

        private void TblItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblItem.Rows[e.RowIndex];
                txtItemCode.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtQty.Text = row.Cells[2].Value.ToString();
                txtPrice.Text = row.Cells[3].Value.ToString();
            }
        }
        private Boolean ValidateText()
        {
            Regex regex = new Regex("^[0-9]{10,10}");
            Regex nameRegex = new Regex("^[a-z][A-Z]{1,}");
            Regex nicRegex = new Regex("^[0-9]{9,9}[v|x]");

            if (Validation.validateTextFields(txtItemCode.Text))
            {
                if (Validation.validateTextFields(txtName.Text))
                {
                    if (Validation.validateTextFields(txtPrice.Text))
                    {
                        if (Validation.validateTextFields(txtQty.Text))
                        {
                            return true;

                        }
                        else
                        {
                            MessageBox.Show("Please fill the quantity");
                            txtQty.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill the price");
                        txtPrice.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Please fill the description");
                    txtName.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please fill the itemcode");
                txtItemCode.Focus();
                return false;
            }
        }
    }
}
