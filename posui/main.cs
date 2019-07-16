using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;  //form draging







namespace posui
{



    public partial class main : Form
    {
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);  //form drag start here
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        private void move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }  //form drag end

        public main()
        {
            //addCustomerbtn.Enabled = false;
            this.MouseDown += new MouseEventHandler(move_window); // Form Drag code
            InitializeComponent();
        }
        private string position = "U";
        public main(String user,string post)
        {
            position = (post == "M") ? "M" : "U";   
            this.MouseDown += new MouseEventHandler(move_window); // Form Drag code
            InitializeComponent();
            lblUsername.Text = user;
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (position == "M")
            {
                homepanel.Controls.Clear();    // load new_user panel
                inventory f = new inventory();
                f.TopLevel = false;
                homepanel.Controls.Add(f);
                f.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signoutbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            login m = new login();
            m.ShowDialog();
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            homepanel.Controls.Clear();    // load new_user panel
            add_user f = new add_user();
            f.TopLevel = false;
            homepanel.Controls.Add(f);
            f.Show();
        }

        private void suppliersbtn_Click(object sender, EventArgs e)
        {
            if (position == "M")
            {
                homepanel.Controls.Clear();    // load new_user panel
                supplier f = new supplier();
                f.TopLevel = false;
                homepanel.Controls.Add(f);
                f.Show();
            }
            
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            if (position == "M")
            {
                homepanel.Controls.Clear();    // load new_user panel
                settings f = new settings();
                f.TopLevel = false;
                homepanel.Controls.Add(f);
                f.Show();
            }
            
        }

        private void Checkoutbtn_Click(object sender, EventArgs e)
        {
            homepanel.Controls.Clear();    // load new_user panel
            checkout f = new checkout();
            f.TopLevel = false;
            homepanel.Controls.Add(f);
            f.Show();
        }

        private void Reportsbtn_Click(object sender, EventArgs e)
        {
            if (position == "M")
            {
                homepanel.Controls.Clear();    // load new_user panel
                report f = new report();
                f.TopLevel = false;
                homepanel.Controls.Add(f);
                f.Show();
            }
        }
    }
    
}
