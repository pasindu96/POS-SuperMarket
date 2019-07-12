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
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
            loadTable();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ItemDTO itemDTO = new ItemDTO(
                    txtItemCode.Text,
                    txtName.Text,
                    int.Parse(txtQty.Text),
                    double.Parse(txtPrice.Text)
                );
            Boolean result= ItemController.addNewItem(itemDTO);
            if (result)
            {
                MessageBox.Show("Item added Successful");
            }
            else
            {
                MessageBox.Show("Error occured.. Item not added to the database");
            }
            clear();
            loadTable();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
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
            txtItemCode.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";

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
    }
}
