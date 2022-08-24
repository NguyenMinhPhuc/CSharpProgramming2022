using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro01_20CT111
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Kiểm tra textbox Tài khoản
            if (!string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                if (!string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    if (KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
                    {
                        trangThaiDongForm = true;
                        ClsMain.taiKhoan = txtTaiKhoan.Text;
                        this.Close();//đóng form login
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản và mật khẩu không đúng \n Xin lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTaiKhoan.ResetText();
                        txtMatKhau.Text = string.Empty;
                        txtTaiKhoan.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập mật khẩu \n Xin lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tài khoản \n Xin lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
            }
            
        }

        private bool KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            if (taiKhoan.Equals("admin") && matKhau.Equals("admin"))
                return true;
            return false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //this.Close();//Đóng form hiện tại
            trangThaiDongForm = true;
            Application.Exit();//đóng toàn bộ chương trình
        }
        bool trangThaiDongForm = false;
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(trangThaiDongForm==true)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

      
    }
}
