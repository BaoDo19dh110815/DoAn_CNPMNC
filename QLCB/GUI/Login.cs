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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {          
            string user = "admin";
            string pass = "123456";
            if (user.Equals(textBoxUser.Text) && pass.Equals(textBoxPw.Text))
            {
                this.Hide();
                MessageBox.Show("Đăng nhập thành công");
                MAIN frm = new MAIN();
                frm.ShowDialog();
                this.Show();
            }
            else               
                MessageBox.Show("Sai tài khoản hoặc mật khẩu !");                      
        }     
    }
}
