﻿using System;
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
            tblViewCustomer.ClearSelection();
            Boolean result=true;
            try
            {
                /*String NIC=txtNIC.Text;
                String name=txtName.Text;
                String mobile=txtMobile.Text;
                String address=txtAddress.Text;*/
                CustomerDTO custDTO = new CustomerDTO(txtNIC.Text, txtName.Text, txtMobile.Text, txtAddress.Text);
                result=CustomerController.updateUser(custDTO);
            }
            catch(Exception ex)
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
        }
    }
}
