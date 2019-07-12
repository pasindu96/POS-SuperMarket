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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            txtUserName.Focus();
            txtUserName.Select();
            
        }

        private void pwtxt_OnTextChange(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void userNametxt_OnTextChange(object sender, EventArgs e)
        {

        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   //form minimize
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                /*LoginDTO loginDTO = LoginController.searchUser(int.Parse(txtUserName.text));
                if (loginDTO.getLoginid() == int.Parse(txtUserName.text) && loginDTO.getPassword() == txtPassword.text)
                {
                    this.Hide();
                    main m = new main(loginDTO.getUsername());
                    m.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Username or password ");
                    txtUserName.text = "";
                    txtPassword.text = "";
                    txtUserName.Focus();
                }*/
                UserLoginDTO loginDTO = LoginController.searchUser((txtUserName.text));
                if (loginDTO.getUsername() == txtUserName.text && loginDTO.getPassword() == txtPassword.text)
                {
                    this.Hide();
                    main m = new main(loginDTO.getName());
                    m.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Username or password ");
                    txtUserName.text = "";
                    txtPassword.text = "";
                    txtUserName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Username or password ");
                Console.WriteLine(ex.ToString());
            }
        }

        private void TxtUserName_KeyPress(object sender, EventArgs e)
        {

        }
    }
}
