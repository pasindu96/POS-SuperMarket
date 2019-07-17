﻿using System;
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
    public partial class supplier : Form
    {
        public supplier()
        {
            InitializeComponent();
            loadTable();
        }

        private void supplierNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            if (ValidateText())
            {
                SupplierDTO supDTO = new SupplierDTO();
                supDTO.setSupplierid(txtSupplierID.Text);
                supDTO.setName(txtSupplierName.Text);
                supDTO.setMobile(txtSupplierMobile.Text);
                supDTO.setAddress(txtSupplierAddress.Text);

                Boolean result = SupplierController.addSupplier(supDTO);
                if (result)
                    MessageBox.Show("Supplier details added to the database successfully..");
                else
                    MessageBox.Show("Error occured supplier not added..");
                loadTable();
                clear();
            }
        }

        private void BtnSupplierDelete_Click(object sender, EventArgs e)
        {
            Boolean result = SupplierController.removeSupplier(txtSupplierID.Text);
            if (result)
                MessageBox.Show("Supplier remove from the database successfully..");
            else
                MessageBox.Show("Error occured supplier not deleted..");
            loadTable();
            clear();
        }

        private void BtnSupplierUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateText())
            {
                SupplierDTO supDTO = new SupplierDTO(txtSupplierID.Text, txtSupplierName.Text, txtSupplierAddress.Text, txtSupplierMobile.Text);
                Boolean result = SupplierController.updateSupplier(supDTO);
                if (result)
                    MessageBox.Show("Supplier details updated in the database successfully..");
                else
                    MessageBox.Show("Error occured supplier details not updated..");
                loadTable();
                clear();
            }
            
        }

        private void loadTable()
        {
            List<SupplierDTO> supList = new List<SupplierDTO>();
            supList = SupplierController.viewUsers();
            tblSupplier.RowCount = 0;
            foreach (SupplierDTO supDTO in supList)
            {
                tblSupplier.Rows.Add(new String[] { supDTO.getSupplierid(), supDTO.getName(), supDTO.getAddress(), supDTO.getMobile()});
            }
        }

        private void TblSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TblSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblSupplier.Rows[e.RowIndex];
                txtSupplierID.Text = row.Cells[0].Value.ToString();
                txtSupplierName.Text = row.Cells[1].Value.ToString();
                txtSupplierAddress.Text = row.Cells[2].Value.ToString();
                txtSupplierMobile.Text = row.Cells[3].Value.ToString();
            }
        }
        private void clear()
        {
            txtSupplierID.Text = "";
            txtSupplierMobile.Text = "";
            txtSupplierName.Text = "";
            txtSupplierAddress.Text = "";
            txtSupplierName.Focus();
        }
        private Boolean ValidateText()
        {
            Regex regex = new Regex("^[0-9]{10,10}");
            Regex nameRegex = new Regex("^[a-z][A-Z]{1,}");
            Regex nicRegex = new Regex("^[0-9]{,9}[v|x]");

            if (Validation.validateTextFields(txtSupplierName.Text))
            {
                if (Validation.validateTextFields(txtSupplierID.Text))
                {
                    if (Validation.validateTextFields(txtSupplierAddress.Text))
                    {
                        if (Validation.validateTextFields(txtSupplierMobile.Text))
                        {
                            if ((txtSupplierMobile.Text.Length == 10))
                            {
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Use 10 charactors only");
                                return false;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Please fill the mobile");
                            txtSupplierMobile.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill the Address");
                        txtSupplierAddress.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Please fill the NIC");
                    txtSupplierID.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please fill the name");
                txtSupplierName.Focus();
                return false;
            }
        }
    }
}
