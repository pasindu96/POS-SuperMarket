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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
            rdbUser.Checked=true;
            loadUsers();
            txtPassword.PasswordChar = '*';
        }

        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string name = txtName.Text;
            string position=(rdbManager.Checked?"M":"U");

            if (username==""||password==""||name=="")
            {
                MessageBox.Show("Please fill all the information");
            }
            else
            {
                UserLoginDTO userLoginDTO = new UserLoginDTO(username, name, password, position);
                Boolean result = LoginController.createUser(userLoginDTO);
                if (result)
                {
                    MessageBox.Show("User added succesfully");
                }
                else
                {
                    MessageBox.Show("User added failed due to an error");
                }
                loadUsers();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string name = txtName.Text;
            string position = (rdbManager.Checked ? "M" : "U");

            if (username == "" || password == "" || name == "")
            {
                MessageBox.Show("Please fill all the information");
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password= txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please Select User Name to Delete");
            }
        }

        private void BtnUserSearch_Click(object sender, EventArgs e)
        {
            string searchUser=txtUserSearch.Text;
            UserLoginDTO userLoginDTO=LoginController.searchUser(searchUser);
            if (userLoginDTO == null)
                MessageBox.Show("No user found....");
            else
            {
                txtUsername.Text = userLoginDTO.getUsername();
                txtName.Text = userLoginDTO.getName();
                if (userLoginDTO.getPosition() == "M")
                    rdbManager.Checked = true;
                else
                    rdbUser.Checked = true;
            }
        }
        void loadUsers()
        {
            List<UserLoginDTO> userList = new List<UserLoginDTO>();
            userList=LoginController.viewCurrentUsers();
            tblCurrentUsers.RowCount = 1;
            if (userList != null)
            {
                foreach (UserLoginDTO users in userList)
                {
                    String[] row = new String[] { users.getUsername(), users.getName(), users.getPosition()=="M" ? "Manager":"User" };
                    tblCurrentUsers.Rows.Add(row);
                }
            }
        }
    }
}
