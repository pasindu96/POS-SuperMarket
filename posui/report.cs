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
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void ReportAddbtn_Click(object sender, EventArgs e)
        {
            double amount = 0.0;
            //MessageBox.Show(dtpReport.Value.ToString("yyyy - MM - dd"));
            List<OrderDTO> list = new List<OrderDTO>();
            list=OrderController.searchOrder(dtpReport.Value.ToString("yyyy-MM-dd"));
            if (list == null)
            {
                MessageBox.Show("No records found on "+ dtpReport.Value.ToString("yyyy-MM-dd"));
            }
            else {
                foreach (OrderDTO order in list)
                {
                    amount += order.getAmount();
                }
                txtReport.Text = "Total sales of the day : ( " + dtpReport.Value.ToString("yyyy-MM-dd") + " ) : ==> " + amount + "/=";
            }            
        }

        private void BtnTimeReport_Click(object sender, EventArgs e)
        {
            double amount = 0.0;
            List<OrderDTO> list = new List<OrderDTO>();
            list = OrderController.searchPeriodicOrder(dtpStart.Value.ToString("yyyy-MM-dd"), dtpEnd.Value.ToString("yyyy-MM-dd"));
            if (list == null)
            {
                MessageBox.Show("No records found on " + dtpReport.Value.ToString("yyyy-MM-dd"));
            }
            else
            {
                foreach (OrderDTO order in list)
                {
                    amount += order.getAmount();
                }
                txtReportPeriod.Text = "Total sales of the period : ( " + dtpStart.Value.ToString("yyyy-MM-dd") + ":"+dtpReport.Value.ToString("yyyy - MM - dd") + "  ) : \n==> " + amount + "/=";
            }
        }
    }
}
