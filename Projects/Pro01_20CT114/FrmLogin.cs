using Pro01_20CT114.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro01_20CT114
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
       public string ThongTin = string.Empty;
        BLLUser bd;
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(ClsMain.pathUser);
            txtMatKhau.Text = "admin";
            txtTaiKhoan.Text = "admin";
           // lblThongTin.Text = ThongTin;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                if (!string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    if (KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
                    {
                        trangThaiDongForm = true;
                        ClsMain.taiKhoan = txtTaiKhoan.Text;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng\n Xin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTaiKhoan.ResetText();
                        txtMatKhau.Text = string.Empty;
                        txtTaiKhoan.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập mật khẩu\n Xin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tài khoản\n Xin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
            }   


           
        }
     
        private bool KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            return bd.KiemTraDangNhap(taiKhoan, matKhau);
        }
        bool trangThaiDongForm = false;
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (trangThaiDongForm == true)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chương trình sẽ được thoát.\n Hãy xác định việc này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //this.Close();//1
                trangThaiDongForm = true;
                Application.Exit();//2
            }
            
        }
    }
}
