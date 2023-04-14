using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCB
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString("HH:mm");
            label_date.Text = DateTime.Now.ToString("MMMM dd yyyy");
            label_day.Text = DateTime.Now.ToString("dddd");
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            timerClock.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.ShowDialog();           
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

          
    }
}
