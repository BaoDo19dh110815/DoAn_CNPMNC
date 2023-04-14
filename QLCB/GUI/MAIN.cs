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
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }

        private void MAIN_Load(object sender, EventArgs e)
        {
            timerClock.Start();
        }
        private void timerClock_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString("HH:mm");
            label_date.Text = DateTime.Now.ToString("M/d/yyyy");
            label_day.Text = DateTime.Now.ToString("dddd");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuNLCB_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanLichChuyenBay fbs = new NhanLichChuyenBay();
            fbs.ShowDialog();
            this.Show();
        }

        private void ToolStripMenuBanVe_DatVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            BanVeChuyenBay fbs = new BanVeChuyenBay();
            fbs.ShowDialog();
            this.Show();
        }

        private void ToolStripMenuQD1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThayDoiQuyDinh1 fbs = new ThayDoiQuyDinh1();
            fbs.ShowDialog();
            this.Show();
        }

        private void ToolStripMenuQD2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThayDoiQuyDinh2 fbs = new ThayDoiQuyDinh2();
            fbs.ShowDialog();
            this.Show();
        }

        private void ToolStripMenuQD3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThayDoiQuyDinh3 fbs = new ThayDoiQuyDinh3();
            fbs.ShowDialog();
            this.Show();
        }

        private void ToolStripMenuBCThang_Click(object sender, EventArgs e)
        {
            this.Hide();
            LapBaoCaoThang fbs = new LapBaoCaoThang();
            fbs.ShowDialog();
            this.Show();
        }

        private void ToolStripMenuBCNam_Click(object sender, EventArgs e)
        {
            this.Hide();
            LapBaoCaoNam fbs = new LapBaoCaoNam();
            fbs.ShowDialog();
            this.Show();
        }

        private void ToolStripMenuQLSanBay_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLySanBay fbs = new QuanLySanBay();
            fbs.ShowDialog();
            this.Show();
        }

        private void ToolStripMenuItemQLChuyenBay_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyChuyenBay fbs = new QuanLyChuyenBay();
            fbs.ShowDialog();
            this.Show();
        }

        private void ToolStripMenuItemQLTuyenBay_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyTuyenBay fbs = new QuanLyTuyenBay();
            fbs.ShowDialog();
            this.Show();
        }
    }
}
