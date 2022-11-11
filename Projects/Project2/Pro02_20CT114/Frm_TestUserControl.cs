using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro02_20CT114
{
    public partial class Frm_TestUserControl : Form
    {
        public Frm_TestUserControl()
        {
            InitializeComponent();
        }

        private void Frm_TestUserControl_Load(object sender, EventArgs e)
        {
            txtUserName.lblTitle.Text = "User name: ";
            txtPassword.lblTitle.Text = "Password: ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(txtUserName.txtNhapLieu.Text, txtPassword.txtNhapLieu.Text))
            {
                MessageBox.Show("Thanh cong");
            }
        }

        private bool KiemTraDangNhap(string userName,string passWord)
        {
            return true;
        }
    }
}
