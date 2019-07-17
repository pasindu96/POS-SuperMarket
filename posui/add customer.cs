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
    public partial class add_user : Form
    {
        public add_user()
        {
            InitializeComponent();
            loadTable();
        }

        private void add_user_Load(object sender, EventArgs e)
        {

        }

        private void AddUserAddBtn_Click(object sender, EventArgs e)
        {
            if (ValidateText())
            {
                tblViewCustomer.ClearSelection();
                CustomerDTO custDTO = new CustomerDTO();
                custDTO.setNic(txtNIC.Text);
                custDTO.setName(txtName.Text);
                custDTO.setMobile(txtMobile.Text);
                custDTO.setAddress(txtAddress.Text);
                Boolean result = CustomerController.createNewUser(custDTO);
                if (result)
                {
                    MessageBox.Show("User added Successful");
                }
                else
                {
                    MessageBox.Show("Error occured.. User not added to the database");
                }
                clear();
                loadTable();
            }           
        }

        private void AddUserDeleteBtn_Click(object sender, EventArgs e)
        {
            tblViewCustomer.ClearSelection();
            Boolean result = CustomerController.removeUser(txtMobile.Text);
            if (result)
            {
                MessageBox.Show("User deleted Successful");
            }
            else
            {
                MessageBox.Show("Error occured.. User not deleted");
            }
            clear();
            loadTable();
        }

        private void AddUserUpdatelBtn_Click(object sender, EventArgs e)
        {
            if(ValidateText()){
                tblViewCustomer.ClearSelection();
                Boolean result = true;
                try
                {
                    CustomerDTO custDTO = new CustomerDTO(txtNIC.Text, txtName.Text, txtMobile.Text, txtAddress.Text);
                    result = CustomerController.updateUser(custDTO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("User details are not updated due to an error");
                    Console.WriteLine(ex.ToString());
                }
                if (result)
                    MessageBox.Show("User details are updated successfully");
                else
                    MessageBox.Show("User details are not updated due to an error");
                clear();
                loadTable();
            }
            
        }
        void loadTable()
        {
            List<CustomerDTO> custList = new List<CustomerDTO>();
            custList=CustomerController.viewUsers();
            tblViewCustomer.RowCount = 0;
            foreach (CustomerDTO cust in custList)
            {
                String[] row = new String[] { cust.getNic(), cust.getName(), cust.getMobile(), cust.getAddress() };
                tblViewCustomer.Rows.Add(row);
            }
        }

        private void TblViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = tblViewCustomer.Rows[e.RowIndex];
                txtNIC.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtAddress.Text = row.Cells[2].Value.ToString();
                txtMobile.Text = row.Cells[3].Value.ToString();
            }
        }
        void clear()
        {
            txtNIC.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtMobile.Text = "";
            txtName.Focus();
        }
        private Boolean ValidateText()
        {
            Regex regex = new Regex("^[0-9]{10,10}");
            Regex nameRegex = new Regex("^[a-z][A-Z]{1,}");
            Regex nicRegex = new Regex("^[0-9]{9,9}[v|x]");

            if (Validation.validateTextFields(txtName.Text))
            {
                if (Validation.validateTextFields(txtNIC.Text))
                {                   
                    if (Validation.validateTextFields(txtAddress.Text))
                    {
                        if (Validation.validateTextFields(txtMobile.Text))
                        {
                            if (txtMobile.Text.Length==10)
                            {
                                return true;
                            }
                            else {
                                MessageBox.Show("Use 10 charactors only");
                                return false;
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Please fill the mobile");
                            txtMobile.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill the Address");
                        txtAddress.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Please fill the NIC");
                    txtNIC.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please fill the name");
                txtName.Focus();
                return false;
            }
        }
    }
}
